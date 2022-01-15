
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuOperation op,
        IEnumerable<NeuArgument> args) {
        
        var returnType = op.GetReturnType();

        ///

        var body = op.GetBodyCodeBlock();

        if (body == null) {

            throw new Exception();
        }

        ///

        var opResult = interpreter.Execute(body, args) as NeuReturnValue;

        if (opResult == null) {

            throw new Exception();
        }

        ///

        if (!opResult.Matches(returnType)) {

            throw new Exception("Value does not match return type");
        }

        ///

        return opResult.Value ?? NeuValue.Void;
    }
}