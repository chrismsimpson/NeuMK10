
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Evaluate(
        this NeuInterpreter interpreter,
        String filename,
        IEnumerable<IArgument> arguments,
        bool dumpAST = false,
        int indent = 0) {

        var parser = NeuParser.FromFile(filename);

        ///

        var source = parser.ParseSource();

        ///

        if (dumpAST) {

            WriteLine($"{source.Dump(indent: indent)}\n");
        }

        ///

        return interpreter.Execute(source, arguments);
    }
}