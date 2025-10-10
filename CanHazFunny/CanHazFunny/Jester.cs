namespace CanHazFunny;

public class Jester
{
    public string JokeServiceInterface { get; set; }
    public string OutputInterface { get; set; }

    Jester(string? jokeService, string? output)
    {
        JokeServiceInterface = jokeService ?? throw new ArgumentNullException(nameof(jokeService));
        OutputInterface = output ?? throw new ArgumentNullException(nameof(output));
    }

    public string TellJoke()
    {
        string generatedJoke;
        do
        {
            generatedJoke = JokeServiceInterface.getJoke();
        } while (!generatedCode.Contains("Chuck Norris"));

        return generatedJoke;
    }
}