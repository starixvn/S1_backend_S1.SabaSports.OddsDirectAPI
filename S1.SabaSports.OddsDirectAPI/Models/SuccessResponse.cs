using System.Text.Json.Serialization;

namespace S1.SabaSports.OddsDirectAPI.Models;

public record SuccessResponse<TResult> : S1Response
{
    [JsonPropertyName("data")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public TResult Data { get; init; }
}