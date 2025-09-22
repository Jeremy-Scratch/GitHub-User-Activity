using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Text;

string user = "Jeremy-Scratch"; //we will ask the user for the username he wants to look up later 
                                //Console.WriteLine("Enter a GitHub user name...");
                                //string user = Console.ReadLine();
using HttpClient client = new();

string token = ""; //DONT COMMINT WITH THIS TOKEN HARDCODED!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!                 
//HEADERS 
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("chosenknight", token);
client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHubUserActivityProject", "1.0"));//MANDATORY FOR GITHUB

var response = await client.GetAsync($"https://api.github.com/users/{user}/events");
response.EnsureSuccessStatusCode();
string data = await response.Content.ReadAsStringAsync();

File.WriteAllText("json.Json", data);