
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Evaluate(
        this NeuInterpreter interpreter,
        String filename,
        bool dumpAST = false) {
            
        var parser = NeuParser.FromFile(filename);

        ///

        var source = parser.ParseSource();

        ///

        if (dumpAST) {

            WriteLine($"{source.Dump()}");
        }

        ///

        return interpreter.Run(source);
    }
}