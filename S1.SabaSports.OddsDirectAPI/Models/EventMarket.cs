namespace S1.SabaSports.OddsDirectAPI.Models;

public class EventMarket
{
    public IEnumerable<Event> Events { get; init; } = default!;

    public IEnumerable<Market> Markets { get; init; } = default!;
}
