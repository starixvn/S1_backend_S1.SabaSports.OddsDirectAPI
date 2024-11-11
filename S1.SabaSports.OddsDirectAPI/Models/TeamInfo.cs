namespace S1.SabaSports.OddsDirectAPI.Models;

public class TeamInfo
{
    public int HomeId { get; init; } = default!;
    public string HomeName { get; init; } = default!;
    public string HomeIconUrl { get; init; } = default!;
    public int AwayId { get; init; } = default!;
    public string AwayName { get; init; } = default!;
    public string AwayIconUrl { get; init; } = default!;
}
