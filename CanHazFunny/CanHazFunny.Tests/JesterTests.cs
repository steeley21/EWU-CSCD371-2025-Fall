using Xunit;
using System;
using System.IO;
using CanHazFunny;

namespace CanHazFunny.Tests;

public class JesterTests
{
    [Fact]
    public void TellJoke_JokeOutput_JokeOutputToStandardOut()
    {
        TextWriter originalOut = Console.Out;
        using var sw = new StringWriter();
        Console.SetOut(sw);
        Jester jester = new Jester(new GoodJokeTestClass(), new ConsoleOutput());
        jester.TellJoke();
        Console.SetOut(originalOut);
        Assert.Equal("Funny joke that does not contain the illegal term.", sw.ToString().Trim());
    }
}

public class GoodJokeTestClass : IJokeService
{
    public string GetJoke()
    {
        return "Funny joke that does not contain the illegal term.";
    }
}

public class BadJokeTestClass : IJokeService
{
    public string GetJoke()
    {
        return "Chuck Norris Hahhahah";
    }
}