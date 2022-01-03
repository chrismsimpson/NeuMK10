
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Run(
        this NeuInterpreter interpreter,
        NeuSource source) {

        return interpreter.RunWithArguments(source);
    }

    public static NeuValue RunWithArguments(
        this NeuInterpreter interpreter,
        NeuNode node) {
            
        interpreter.Enter(node);

        ///

        var lastValue = NeuValue.Void;

        foreach (var child in node.Children) {

            switch (child) {

                ///

                default:

                    WriteLine("NO OP");

                    break;
            }
        }

        ///

        interpreter.Exit(node);

        ///

        return lastValue;
    }
}