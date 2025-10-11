using Xunit;
using System;
using System.IO;
using CanHazFunny;
using System.Reflection;

namespace CanHazFunny.Tests;

public class JokeServiceTests
{
    [Fact]
    public void GetJoke_ShouldReturnNonEmptyString()
    {
        JokeService jokeService = new JokeService();
        string joke = jokeService.GetJoke();
        Assert.NotNull(joke);
        Assert.IsType<string>(joke);
    }
}