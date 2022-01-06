
namespace Neu;

public static partial class Program {

    public static async Task Main(
        String[] args) {

        var arguments = args
            .ToArguments();

        ///

        var name = arguments
            .GetFirstArgumentSource();

        ///

        var command = arguments
            .ToCommand();

        var commandName = command.GetName();

        ///

        var stopwatch = Stopwatch.StartNew();

        WriteLine($"\n//");
        WriteLine($"//  neu {commandName}");
        WriteLine($"//\n");

        await command.Run(
            arguments: arguments);

        stopwatch.Stop();

        WriteLine($"{commandName} completed in {stopwatch.GetElapsedString()}");
    }
}