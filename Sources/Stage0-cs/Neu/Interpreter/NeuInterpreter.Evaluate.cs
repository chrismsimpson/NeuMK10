
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Evaluate(
        this NeuInterpreter interpreter,
        String filename) {
            
        var parser = NeuParser.FromFile(filename);

        ///

        var source = parser.ParseSource();

        ///

        return interpreter.Run(source);
    }
}