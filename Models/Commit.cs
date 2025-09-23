using System.Text.Json.Serialization;
public class Commit
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
};