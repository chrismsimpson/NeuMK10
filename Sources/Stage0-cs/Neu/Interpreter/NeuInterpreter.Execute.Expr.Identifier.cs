
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuIdentifierExpression idExpr) {

        var id = idExpr.GetIdentifier();

        if (id == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(id);
    }
}