namespace S1.SabaSports.OddsDirectAPI.Models;

public class GameInfo
{
    public byte LivePeriod { get; init; } = default!;
    public string ClockDirection { get; init; } = default!;
    public int Seconds { get; init; } = default!;
    public bool IsNeutral { get; init; } = default!;
    public bool IsHt { get; init; } = default!;
    public bool IsBreak { get; init; } = default!;
    public bool IsClosed { get; init; } = default!;
    public byte InJuryTime { get; init; } = default!;
    public bool DelayLive { get; init; } = default!;
    public byte GameStatus { get; init; } = default!;
    public string InPlayTime { get; init; } = default!;
    public int LiveHomeScore { get; init; } = default!;
    public int LiveAwayScore { get; init; } = default!;
}
