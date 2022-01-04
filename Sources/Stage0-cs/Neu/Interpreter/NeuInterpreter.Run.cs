
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Run(
        this NeuInterpreter interpreter,
        NeuNode node) {
            
        interpreter.Enter(node);

        ///

        NeuValue lastValue = NeuValue.Void;

        var done = false;

        for (var i = 0; i < node.Children.Count() && !done; i++) {

            var child = node.Children.ElementAt(i);

            switch (interpreter.Execute(child)) {

                case NeuReturnValue returnValue:

                    lastValue = returnValue.Value ?? NeuValue.Void;

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

            var body = func.GetBody();

            if (body == null) {

                throw new Exception();
            }

            lastValue = interpreter.Run(body);
        }

        ///

        return lastValue;
    }
}