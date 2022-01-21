
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuExpression expr) {

        switch (expr) {



            
            case NeuLiteralExpression litExpr:

                return interpreter.Execute(litExpr);

            ///

            case NeuIdentifierExpression idExpr:

                return interpreter.Execute(idExpr);

            ///

            case NeuCallExpression callExpr:

                return interpreter.Execute(callExpr);











            ///

            case NeuUnaryExpression unaryExpr when !unaryExpr.IsFixExpression():

                return interpreter.Execute(unaryExpr);

            ///

            case NeuPrefixExpression prefixExpr:

                return interpreter.Execute(prefixExpr);

            ///

            case NeuInfixExpression infixExpr:

                return interpreter.Execute(infixExpr);

            ///

            case NeuPostfixExpression postfixExpr:

                return interpreter.Execute(postfixExpr);


            ///

            default:
                
                throw new Exception();
        }
    }
}