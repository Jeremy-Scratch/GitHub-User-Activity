using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;

string jsonC = File.ReadAllText("json.Json");

List<Events>? events = JsonSerializer.Deserialize<List<Events>>(jsonC);


foreach (var ev in events!)
{
    Console.WriteLine($"user {ev.Actor!.UserLogin} type {ev.EventType}: {ev.payload!.Action} in the repository: {ev.Repo!.RepoName} Nombre:'{ev.payload.Commits}'");
}