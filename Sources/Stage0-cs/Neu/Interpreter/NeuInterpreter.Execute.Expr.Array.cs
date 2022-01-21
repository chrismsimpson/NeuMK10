
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuArrayExpression arrayExpr) {

        var arrayElementList = arrayExpr.GetArrayElementList();

        if (arrayElementList == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(arrayElementList);
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuArrayElementList arrayElementList) {

        var evaluatedElements = new List<NeuOperation>();

        ///

        foreach (var child in arrayElementList.Children) {

            var element = child as NeuArrayElement;

            if (element == null) {

                throw new Exception();
            }

            ///

            var evaluatedElement = interpreter.Execute(element);

            evaluatedElements.Add(evaluatedElement);
        }

        ///

        return new NeuArray(evaluatedElements);
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuArrayElement arrayElement) {

        var expr = arrayElement.GetExpression();

        if (expr == null) {

            throw new Exception();
        }

        ///

        return interpreter.Execute(expr);
    }
}