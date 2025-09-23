using System.Text.Json.Serialization;
public class PayLoad
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }
    [JsonPropertyName("commits")]
    public List<Commit> Commits { get; set; } = [];
    [JsonPropertyName("size")]
    public int Size { get; set; }
    [JsonPropertyName("ref_type")]
    public string? RefType { get; set; } 
};