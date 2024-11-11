namespace S1.SabaSports.OddsDirectAPI.Models;

public class Market
{
    public int SportType { get; init; } = default!;
    public int EventId { get; init; } = default!;
    public int BetType { get; init; } = default!;
    public string BetTypeName { get; init; } = default!;
    public int MarketId { get; init; } = default!;
    public decimal MaxBet { get; init; } = default!;
    public bool IsLive { get; init; } = default!;
    public string MarketStatus { get; init; } = default!;
    public short? GameMap { get; init; } = default!;
    public short? GameRound { get; init; } = default!;
    public string ResourceId { get; init; } = default!;
    public int Category { get; init; } = default!;
    public string ShowCategory { get; init; } = default!;
    public int Sort { get; init; } = default!;
    public int Combo { get; init; } = default!;
    public IEnumerable<SelectionInfo> Selections { get; init; } = default!;
}
