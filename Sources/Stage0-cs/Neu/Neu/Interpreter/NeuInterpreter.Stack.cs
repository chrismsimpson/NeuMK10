
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static void Enter(
        this NeuInterpreter interpreter,
        NeuNode node) {

        interpreter.Stack.Push(new NeuFrame(node));
    }

    public static void Exit(
        this NeuInterpreter interpreter,
        NeuNode node) {

        var frame = interpreter.Stack.First();

        ///

        var frameNode = frame.Node as NeuNode;

        if (frameNode == null) {

            throw new Exception();
        }

        ///

        if (!Equals(frameNode, node)) {
            
            throw new Exception();
        }

        ///

        interpreter.Stack.Pop();
    }
}