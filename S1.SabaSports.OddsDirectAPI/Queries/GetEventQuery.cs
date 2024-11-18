namespace S1.SabaSports.OddsDirectAPI.Queries;

public class GetEventQuery
{
    public int[] SportType { get; set; }

    public int[] BetType { get; set; }

    public string LeagueIds { get; set; }

    public bool? IsLive { get; set; }

    public int Top { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public string VendorId { get; set; }

    public string VendorMemberId { get; set; }
}
