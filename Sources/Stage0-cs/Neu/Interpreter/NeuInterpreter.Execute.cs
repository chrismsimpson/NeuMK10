
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuNode node,
        params object[] arguments) {
            
        interpreter.Enter(node);

        ///

        NeuValue lastValue = NeuValue.Void;

        var done = false;

        for (var i = 0; i < node.Children.Count() && !done; i++) {

            var child = node.Children.ElementAt(i);

            ///

            var childResult = interpreter.Execute(child);

            ///

            switch (childResult) {

                case NeuReturnValue returnValue:

                    lastValue = returnValue;
                    // lastValue = returnValue.Value ?? NeuValue.Void;

                    done = true;

                    break;

                ///

                case NeuValue value:

                    lastValue = value;

                    break;

                ///

                default:

                    break;
            }
        }

        ///

        interpreter.Exit(node);

        ///

        if (interpreter.Stack.Count == 0 && 
            lastValue is NeuFunc func &&
            func.Name == "main") {

            var body = func.GetBodyCodeBlock();

            if (body == null) {

                throw new Exception();
            }

            ///

            var funcResult = interpreter.Execute(body) as NeuReturnValue;

            if (funcResult == null) {

                throw new Exception();
            }

            ///

            ///

            lastValue = funcResult.Value ?? NeuValue.Void;
        }

        ///

        return lastValue;
    }
}