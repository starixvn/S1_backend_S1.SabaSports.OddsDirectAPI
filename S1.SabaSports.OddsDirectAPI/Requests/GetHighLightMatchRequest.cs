using MediatR;
using S1.SabaSports.OddsDirectAPI.Models;

namespace S1.SabaSports.OddsDirectAPI.Requests;

public class GetHighLightMatchRequest : IRequest<IEnumerable<Match>>
{
    public int[] SportType { get; set; }

    public string LeagueIds { get; set; }

    public int[] Bettype { get; set; }

    public int Top { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public bool? IsLive { get; set; }

    public string VendorId { get; set; }

    public string VendorMemberId { get; set; }
}
