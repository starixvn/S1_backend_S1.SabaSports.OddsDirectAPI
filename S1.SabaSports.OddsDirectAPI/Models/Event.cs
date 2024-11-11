namespace S1.SabaSports.OddsDirectAPI.Models;

public class Event
{
    public int SportType { get; init; } = default!;
    public string SportName { get; init; } = default!;
    public int LeagueId { get; init; } = default!;
    public string LeagueName { get; init; } = default!;
    public string LeagueIconUrl { get; init; } = default!;
    public int EventId { get; init; } = default!;
    public string EventCode { get; init; } = default!;
    public string EventStatus { get; init; } = default!;
    public bool IsMainMarket { get; init; } = default!;
    public DateTime KickOffTime { get; init; } = default!;
    public DateTime GlobalShowTime { get; init; } = default!;
    public string CountryCode { get; init; } = default!;
    public int GameSession { get; init; } = default!;
    public int ParentId { get; init; } = default!;
    public bool IsTest { get; init; } = default!;
    public bool IsLive { get; init; } = default!;
    public bool IsParlay { get; init; } = default!;
    public bool IsCashout { get; init; } = default!;
    public bool IsVirtualEvent { get; init; } = default!;
    public bool HasLiveMarket { get; init; } = default!;
    public int MarketCount { get; init; } = default!;
    public int[] MarketCategories { get; init; } = default!;
    public int StreamingOption { get; init; } = default!;
    public string ChannelCode { get; init; } = default!;
    public TeamInfo TeamInfo { get; init; } = default!;
    public GameInfo GameInfo { get; init; } = default!;
}
