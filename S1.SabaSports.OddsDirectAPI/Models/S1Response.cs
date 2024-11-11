using System.Text.Json.Serialization;

namespace S1.SabaSports.OddsDirectAPI.Models;

public record S1Response
{
    [JsonPropertyName("err")]
    public int Error { get; init; }

    [JsonPropertyName("errmsg")]
    public string ErrorMessage { get; init; }

    [JsonPropertyName("errmsgid")]
    public string ErrorMessageKey { get; init; }

    public S1Response()
    {
    }
}
