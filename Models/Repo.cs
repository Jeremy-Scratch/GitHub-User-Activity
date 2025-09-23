using System.Text.Json.Serialization;
public class Repo
{
    [JsonPropertyName("name")]
    public string? RepoName { get; set; }
};