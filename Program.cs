using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http.Headers;

Console.WriteLine("Enter a GitHub user name...");
string? user = Console.ReadLine();
using HttpClient client = new();

string token = ""; //DONT COMMINT WITH THIS TOKEN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                 
//HEADERS 
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("chosenknight", token);
client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHubUserActivityProject", "1.0"));//MANDATORY FOR GITHUB
//GET
var response = await client.GetAsync($"https://api.github.com/users/{user}/events");
response.EnsureSuccessStatusCode();
string data = await response.Content.ReadAsStringAsync();
List<Events>? events = JsonSerializer.Deserialize<List<Events>>(data);

Console.WriteLine($"GitHub events from the user: {user}\n");
foreach (var ev in events!)
{
    var action = ev.EventType;
    string message;
    switch (action)
    {
        case "PushEvent": message = $"Did {ev.payload!.Size} Commit/s in {ev.Repo!.RepoName}"; break;
        case "CreateEvent": message = $"Create a new {ev.payload!.RefType} in {ev.Repo!.RepoName}"; break;
        case "WatchEvent": message = $"Starred {ev.Repo!.RepoName}"; break;
        default: message = $"{ev.EventType} {ev.payload!.Action} repository: {ev.Repo!.RepoName} {ev.payload.Size} "; break;
    }
    Console.WriteLine(message);
}