using Microsoft.Extensions.Options;
using S1.SabaSports.OddsDirectAPI.Models;
using S1.SabaSports.OddsDirectAPI.Options;
using S1.SabaSports.OddsDirectAPI.Requests;

namespace S1.SabaSports.OddsDirectAPI.Services;

public interface ISabaService
{
    Task<TokenInfo> LoginSabaAsync(string vendorId, string vendorMemberId);

    Task<IEnumerable<Match>> GetHighLightMatchAsync(GetHighLightMatchRequest request, TokenInfo token);
}
public class SabaService(IOptions<SabaSettings> options, IApiClient apiClient) : ISabaService
{
    public async Task<TokenInfo> LoginSabaAsync(string vendorId, string vendorMemberId)
    {
        return await apiClient.PostDataAsync<TokenInfo>($"{options.Value.Url}/login", new
        {
            Vendor_Id = vendorId,
            Vendor_member_id = vendorMemberId
        });
    }

    public async Task<IEnumerable<Match>> GetHighLightMatchAsync(GetHighLightMatchRequest request, TokenInfo token)
    {
        var eventMarket = await GetEventAsync(request, token);


        return eventMarket.Events.Select(e => new Match
        {
            SportType = e.SportType,
            SportName = e.SportName,
            LeagueId = e.LeagueId,
            LeagueName = e.LeagueName,
            LeagueIconUrl = e.LeagueIconUrl,
            EventId = e.EventId,
            EventCode = e.EventCode,
            EventStatus = e.EventStatus,
            IsMainMarket = e.IsMainMarket,
            KickOffTime = e.KickOffTime,
            GlobalShowTime = e.GlobalShowTime,
            CountryCode = e.CountryCode,
            IsLive = e.IsLive,
            MarketCount = e.MarketCount,
            ChannelCode = e.ChannelCode,
            TeamInfo = e.TeamInfo,
            GameInfo = e.GameInfo,
            Markets = eventMarket.Markets.Where(m => m.EventId == e.EventId && request.Bettype.Contains(m.BetType) && m.MarketStatus == "running" && m.Selections.Any()).OrderBy(m => m.Sort)
        }).Where(m => m.Markets != null && m.Markets.Any());
    }

    private async Task<EventMarket> GetEventAsync(GetHighLightMatchRequest request, TokenInfo token)
    {
        var marketQuery = getMarketQuery(request);
        var query = GetQuery(request);

        return await apiClient.GetDataAsync<EventMarket>(
            $"{options.Value.Url}/sports/v1/GetEvents?{query}" +
            $"{marketQuery}" +
            $"&language=en" +
            $"&from={request.From}" +
            $"&until={request.To}",
            token.Access_Token);
    }

    private string getMarketQuery(GetHighLightMatchRequest request)
    {
        var queries = new List<string>()
        {
            request.Bettype is not null && request.Bettype.Any() ? $"bettype in ({string.Join(',', request.Bettype)})"
                : string.Empty
        };

        var validQuery = queries.Where(q => !string.IsNullOrEmpty(q)).ToList();
        return validQuery.Any() ? $"&includeMarkets=$filter={string.Join(" and ", validQuery)}" : string.Empty;
    }

    private string GetQuery(GetHighLightMatchRequest request)
    {
        var queries = new List<string>()
        {
            request.IsLive is null ? string.Empty : $"islive eq {request.IsLive.ToString().ToLower()}",
            request.LeagueIds is not null && request.LeagueIds.Any() ? $"leagueid in ({request.LeagueIds})" : string.Empty,
            request.SportType is not null && request.SportType.Any()
                ? $"sporttype in ({string.Join(',', request.SportType)})"
                : string.Empty
        };

        var validQuery = queries.Where(q => !string.IsNullOrEmpty(q)).ToList();

        return validQuery.Any() ? $"query=$filter={string.Join(" and ", validQuery)}" : string.Empty;
    }
}
