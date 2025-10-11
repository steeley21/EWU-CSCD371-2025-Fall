using System.Net.Http;
using System.Net.Http.Json;
using System;
using System.Text.Json;
using System.Collections.Generic;

namespace CanHazFunny;

public class JokeService : IJokeService
{
    private HttpClient HttpClient { get; } = new();

    public string GetJoke()
    {
        string json = HttpClient.GetStringAsync("https://geek-jokes.sameerkumar.website/api?format=json").Result;
        var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
        if (dict is not null)
        {
            Console.WriteLine(dict["joke"]);
            return dict["joke"];
        }
        return string.Empty;
    }
}
