using MediatR;
using S1.SabaSports.OddsDirectAPI.Models;
using S1.SabaSports.OddsDirectAPI.Requests;
using S1.SabaSports.OddsDirectAPI.Services;

namespace S1.SabaSports.OddsDirectAPI.Handlers;

public class SabaHandler(ISabaService sabaService, IApiClient apiClient) : IRequestHandler<GetHighLightMatchRequest, IEnumerable<Match>>
{
    public async Task<IEnumerable<Match>> Handle(GetHighLightMatchRequest request, CancellationToken cancellationToken)
    {
        var token = await sabaService.LoginSabaAsync(request.VendorId, request.VendorMemberId);

        var results = await sabaService.GetHighLightMatchAsync(request, token);

        return results;
    }
}
