using System.Text.Json.Serialization;
public class Actor
{
    [JsonPropertyName("display_login")]
    public string? UserLogin { get; set; }
    [JsonPropertyName("url")]
    public string? UserUrl { get; set; }
};