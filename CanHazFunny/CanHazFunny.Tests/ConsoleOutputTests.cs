using System;
using System.IO;
using Xunit;


namespace CanHazFunny.Tests;

public class ConsoleOutputTests
{

    [Fact]
    public void WriteLine_WithMessage_WritesMessageAndNewLine()
    {
        var consoleOutput = new ConsoleOutput();
        var original = Console.Out;
        using var sw = new StringWriter();

        try
        {
            Console.SetOut(sw);
            consoleOutput.WriteLine("hello");
            Assert.Equal("hello" + Environment.NewLine, sw.ToString());
        }
        finally
        {
            Console.SetOut(original);
        }
    }

    [Fact]
    public void WriteLine_WithEmptyString_WritesNewLineOnly()
    {
        var consoleOutput = new ConsoleOutput();
        var original = Console.Out;
        using var sw = new StringWriter();

        try
        {
            Console.SetOut(sw);
            consoleOutput.WriteLine(string.Empty);
            Assert.Equal(Environment.NewLine, sw.ToString());
        }
        finally
        {
            Console.SetOut(original);
        }
    }

    [Fact]
    public void WriteLine_OnMultipleCalls_AppendsEachOnNewLine()
    {
        var consoleOutput = new ConsoleOutput();
        var original = Console.Out;
        using var sw = new StringWriter();

        try
        {
            Console.SetOut(sw);
            consoleOutput.WriteLine("first");
            consoleOutput.WriteLine("second");
            Assert.Equal($"first{Environment.NewLine}second{Environment.NewLine}", sw.ToString());
        }
        finally
        {
            Console.SetOut(original);
        }
    }
}
