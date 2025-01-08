using System.Text.Json.Serialization;

namespace GetFullYear.NET;

internal class Response
{
    [JsonPropertyName("year")]
    public required int Year { get; set; }
    
    [JsonPropertyName("sponsored_by")]
    public required string SponsoredBy { get; set; }
    
    [JsonPropertyName("year_string")]
    public required string YearString { get; set; }
}