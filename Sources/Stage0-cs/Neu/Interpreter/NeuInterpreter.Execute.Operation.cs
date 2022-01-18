
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
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

        var returnResult = interpreter.Execute(body, args) as NeuReturnResult;

        if (returnResult == null) {

            throw new Exception();
        }

        ///

        if (!returnResult.Matches(returnType)) {

            throw new Exception("Value does not match return type");
        }

        ///

        return returnResult.Result ?? NeuOperation.Void;
    }
}