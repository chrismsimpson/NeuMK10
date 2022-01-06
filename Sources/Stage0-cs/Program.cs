
namespace Neu;

public static partial class Program {

    public static void Main(
        String[] args) {

        var stopwatch = Stopwatch.StartNew();

        ///

        var tests = GetTestsDirectory("Neu");

        ///

        var files = new [] {
            "test00.neu", // empty file, return void
            "test01.neu"  // basic main, return zero
        };

        ///

        foreach (var file in files) {

            var filename = Combine(tests, file);

            WriteLine($"Evaluating: {filename}\n");

            var interpreter = new NeuInterpreter();

            var result = interpreter.Evaluate(filename, dumpAST: true);

            WriteLine($"{result.Dump()}\n\n");
        }

        ///
        
        stopwatch.Stop();

        ///

        WriteLine($"Time elapsed: {stopwatch.Elapsed.TotalMilliseconds}ms");
    }
}