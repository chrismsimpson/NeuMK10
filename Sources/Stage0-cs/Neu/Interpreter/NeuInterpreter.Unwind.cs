
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static void Unwind(
        this NeuInterpreter interpreter,
        int enterPos,
        NeuNode node) {

        var exitPos = interpreter.Stack.Count();

        ///

        var additionalStackFrames = exitPos - enterPos;

        if (additionalStackFrames > 0) {

            for (var i = additionalStackFrames; i > 0; --i) {

                var frame = interpreter.Stack.Pop();

                ///

                switch (frame) {

                    default:

                        // TODO: add to results?

                        // throw new Exception();

                        break;
                }
            }
        }
        else if (additionalStackFrames < 0) {

            throw new Exception();
        }
    }
}