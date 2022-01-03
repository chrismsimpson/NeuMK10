
namespace Neu;

public static partial class Program {

    public static void Main(
        String[] args) {

        var tests = GetTestsDirectory("Neu");

        var filename = Combine(tests, "test00.neu");

        var interpreter = new NeuInterpreter();

        var result = interpreter.Evaluate(filename);

        WriteLine($"{result}");

        // var s = NeuParser.FromFile(f);

        // var s2 = s.ParseSource();

        // WriteLine($"{s2.Dump()}");
    }
}