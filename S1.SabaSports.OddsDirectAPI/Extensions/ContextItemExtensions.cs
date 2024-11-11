namespace S1.SabaSports.OddsDirectAPI.Extensions;

internal static class ContextItemExtensions
{
    public static Guid GetBrandId(this IDictionary<object, object?> items)
    {
        return items.TryGetValue("BrandId", out var v) && v != null ? Guid.Parse(v.ToString()) : Guid.Empty;
    }
}
