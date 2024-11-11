namespace S1.SabaSports.OddsDirectAPI.Models;

public class OddsPriceInfo
{
    public decimal ParlayPrice { get; init; } = default!;
    public decimal MalayPrice { get; init; } = default!;
    public decimal HongKongPrice { get; init; } = default!;
    public decimal DecimalPrice { get; init; } = default!;
    public decimal IndoPrice { get; init; } = default!;
    public decimal AmericanPrice { get; init; } = default!;
}
