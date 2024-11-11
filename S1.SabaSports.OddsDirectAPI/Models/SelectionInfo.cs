namespace S1.SabaSports.OddsDirectAPI.Models;

public class SelectionInfo
{
    public string Key { get; init; } = default!;
    public string KeyName { get; init; } = default!;
    public decimal? Point { get; init; } = default!;
    public decimal? Point2 { get; init; } = default!;

    public OddsPriceInfo OddsPrice { get; init; } = default!;
}
