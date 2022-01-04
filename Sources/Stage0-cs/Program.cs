
namespace Neu;

public static partial class Program {

    public static void Main(
        String[] args) {

        var stopwatch = Stopwatch.StartNew();

        var tests = GetTestsDirectory("Neu");

        var filename = Combine(tests, "test00.neu");

        var interpreter = new NeuInterpreter();

        var result = interpreter.Evaluate(filename, dumpAST: true);

        WriteLine($"{result}");

        stopwatch.Stop();

        WriteLine($"Time elapsed: {stopwatch.Elapsed.TotalMilliseconds}ms");
    }
}