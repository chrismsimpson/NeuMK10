
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuVar? GetVar(
        this NeuInterpreter interpreter,
        String name) {

        /// Locals

        if (interpreter.GetLocalVar(name) is NeuVar localVar) {

            return localVar;
        }

        // Globals

        if (interpreter.GetGlobalVar(name) is NeuVar globalVar) {

            return globalVar;
        }

        ///
        
        return null;
    }

    public static NeuVar? GetLocalVar(
        this NeuInterpreter interpreter,
        String name) {

        var hoistedFrame = interpreter.GetHoistedFrameWithinScope(name);

        if (hoistedFrame == null) {

            return null;
        }

        ///

        return hoistedFrame.Operation as NeuVar;
    }

    public static NeuHoistedFrame? GetHoistedFrameWithinScope(
        this NeuInterpreter interpreter,
        String name) {

        foreach (var frame in interpreter.Stack) {

            switch (frame) {

                case NeuScopeFrame _:

                    return null;

                ///

                case NeuHoistedFrame hoistedFrame when hoistedFrame.Hoist.Name == name:

                    return hoistedFrame;

                ///

                default:

                    continue;
            }
        }

        ///

        return null;
    }

    ///

    public static NeuVar? GetGlobalVar(
        this NeuInterpreter interpreter,
        String name) {

        var ops = interpreter.GetOperations(name, null, null, null);

        ///

        var op = ops.SingleOrDefault();

        if (op == null) {

            return null;
        }

        ///

        return op as NeuVar;
    }
}