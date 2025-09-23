using System.Text.Json.Serialization;
public class Events
{
    [JsonPropertyName("type")]
    public string? EventType { get; set; }
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    [JsonPropertyName("actor")]
    public Actor? Actor { get; set; }
    [JsonPropertyName("repo")]
    public Repo? Repo { get; set; }
    [JsonPropertyName("payload")]
    public PayLoad? Payload { get; set; }
};