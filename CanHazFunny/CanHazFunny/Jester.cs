using System;

namespace CanHazFunny;

public class Jester
{
    private IJokeService _JokeServiceInterface { get; set; }
    private IOutput _OutputInterface { get; set; }

    public Jester(IJokeService? jokeService, IOutput? output)
    {
        ArgumentNullException.ThrowIfNull(jokeService);
        ArgumentNullException.ThrowIfNull(output);
        _JokeServiceInterface = jokeService;
        _OutputInterface = output;
    }

    public void TellJoke()
    {
        string generatedJoke = string.Empty;
        do
        {
            generatedJoke = _JokeServiceInterface.GetJoke();
        } while (generatedJoke.Contains("Chuck Norris"));

        _OutputInterface.WriteLine(generatedJoke);
    }
}