
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuIdentifier id) {

        var name = id.Source;

        ///

        var v = interpreter.GetVar(name);

        if (v == null) {

            throw new Exception();
        }

        ///

        return v.Value;
    }
}