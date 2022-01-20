
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation PostfixDecrement(
        this NeuInterpreter interpreter,
        NeuExpression operand) {

        var id = operand.GetIdentifier();

        if (id == null) {

            throw new Exception();
        }

        ///

        var name = id.Source;

        ///

        var operandResult = interpreter.Execute(operand);

        ///

        switch (true) {

            case var _
                when 
                    operandResult is NeuInteger intResult:

                return interpreter.PostfixDecrement(name, intResult);

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuOperation PostfixDecrement(
        this NeuInterpreter interpreter,
        String name,
        NeuInteger intResult) {

        var updatedResult = new NeuInteger(intResult.Value - 1);

        ///

        if (!interpreter.SetVar(name, updatedResult)) {

            throw new Exception();
        }

        ///

        return intResult;
    }
}