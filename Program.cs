using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;
using System.Text;


using var client = new HttpClient();
string user = "Jeremy-Scratch";
// string token = "a18c3bded88eb5dbb5c849a489412bf3";
string url = $"https://api.github.com/users/{user}/events";
// client.DefaultRequestHeaders.Add("Authorization", token);
// var respond = client.GetAsync(url).Result;
// var res = respond.Content.ReadAsStringAsync().Result;
// dynamic r = JsonSerializer.Serialize(res);

Console.WriteLine(url);
