
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static bool SetVar(
        this NeuInterpreter interpreter,
        String name,
        NeuOperation newValue) {

        /// Locals

        if (interpreter.SetLocalVar(name, newValue)) {

            return true;
        }

        /// Globals

        if (interpreter.SetGlobalVar(name, newValue)) {

            return true;
        }

        ///

        return false;
    }

    ///

    public static bool SetLocalVar(
        this NeuInterpreter interpreter,
        String name,
        NeuOperation newValue) {

        var hoistedFrame = interpreter.GetHoistedFrameWithinScope(name);

        if (hoistedFrame == null) {

            return false;
        }

        ///

        var v = hoistedFrame.Operation as NeuVar;

        if (v == null) {

            throw new Exception();
        }

        ///

        v.Value = newValue;

        ///

        return true;
    }

    ///

    public static bool SetGlobalVar(
        this NeuInterpreter interpreter,
        String name,
        NeuOperation newValue) {

        var ops = interpreter.GetOperations(name, null, null, null);

        ///

        var op = ops.SingleOrDefault();

        if (op == null) {

            return false;
        }

        ///

        var v = op as NeuVar;

        if (v == null) {

            throw new Exception();
        }

        ///

        v.Value = newValue;

        ///

        return true;
    }
}