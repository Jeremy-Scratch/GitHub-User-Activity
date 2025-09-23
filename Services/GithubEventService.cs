using System.Text.Json;
using System.Net.Http.Headers;

public class EventService
{
    public async Task<List<Events>> Getter(string? user)
    {
        string token = Environment.GetEnvironmentVariable("MY_TOKEN", EnvironmentVariableTarget.User) ?? throw new InvalidOperationException("GITHUB_TOKEN environment variable not set.");
        
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("chosenknight", token);
        client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHubUserActivityProject", "1.0"));
        var response = await client.GetAsync($"https://api.github.com/users/{user}/events");
        response.EnsureSuccessStatusCode();
        string data = await response.Content.ReadAsStringAsync();
        List<Events>? events = JsonSerializer.Deserialize<List<Events>>(data);
        return events!;
    }
 }