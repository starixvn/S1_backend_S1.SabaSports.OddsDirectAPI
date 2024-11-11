namespace S1.SabaSports.OddsDirectAPI.Options;

public class SabaSettings
{
    public string Url { get; init; } = default!;

    public string VendorId { get; init; } = default!;

    public string VendorMemberId { get; init; } = default!;

    public int TokenExpiration { get; init; } = default!;

    public int DataExpiration { get; init; } = default!;

    public string Proxy { get; set; } = default!;
}
