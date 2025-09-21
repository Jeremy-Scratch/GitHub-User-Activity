using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Nodes;

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
    public PayLoad? payload { get; set; }

    
    
};

public class Actor
{
    [JsonPropertyName("display_login")]
    public string? UserLogin { get; set; }
    [JsonPropertyName("url")]
    public string? UserUrl { get; set; }
};

public class Repo
{
    [JsonPropertyName("name")]
    public string? RepoName { get; set; }
};

public class PayLoad
{
    [JsonPropertyName("action")]
    public string? Action { get; set; }
    [JsonPropertyName("commits")]
    public List<Commit>? Commits { get; set; }
};

public  class Commit
{
    [JsonPropertyName("message")]
    public string? Message { get; set; }
};


