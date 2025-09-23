using System;

Console.WriteLine("Enter a GitHub user name...");
string? user = Console.ReadLine();
EventService service = new();
List<Events> events =  await service.Getter(user);
Console.WriteLine($"GitHub events from the user: {user}\n");
foreach (var ev in events!)
{
    var action = ev.EventType;
    string message;
    switch (action)
    {
        case "PushEvent": message = $"Pushed {ev.Payload!.Size} Commit/s \"{ev.Payload.Commits.FirstOrDefault()?.Message}\" in {ev.Repo!.RepoName}"; break;
        case "CreateEvent": message = $"Created a new {ev.Payload!.RefType} in {ev.Repo!.RepoName}"; break;
        case "WatchEvent": message = $"Starred {ev.Repo!.RepoName}"; break;
        default: message = $"{ev.EventType} {ev.Payload!.Action} repository: {ev.Repo!.RepoName} {ev.Payload.Size}"; break;
    }
    Console.WriteLine(message);
}