
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

            var result = interpreter.Execute(child);

            ///

            switch (result) {

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

            lastValue = interpreter.Execute(body);
        }

        ///

        return lastValue;
    }
}