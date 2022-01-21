
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuUnaryExpression unaryExpr) {

        if (unaryExpr.IsFixExpression()) {

            throw new Exception();
        }

        ///

        switch (unaryExpr) {

            case NeuSizeOfExpression sizeOfExpr:

                return interpreter.Execute(sizeOfExpr);
                
            ///

            default:

                throw new Exception();
        }
    }
}