
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuExpressionStatement expressionStatement) {

        var expression = expressionStatement.GetExpression();

        if (expression == null) {

            throw new Exception();
        }

        return interpreter.Execute(expression);
    }
}
