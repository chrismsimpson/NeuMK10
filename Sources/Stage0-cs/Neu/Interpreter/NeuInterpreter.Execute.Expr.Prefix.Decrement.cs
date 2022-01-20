
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation PrefixDecrement(
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

                return interpreter.PrefixDecrement(name, intResult);

            ///

            default:

                throw new Exception();
        }
    }

    public static NeuOperation PrefixDecrement(
        this NeuInterpreter interpreter,
        String name,
        NeuInteger intResult) {

        var updatedResult = new NeuInteger(intResult.Value - 1);

        ///

        if (!interpreter.SetVar(name, updatedResult)) {

            throw new Exception();
        }

        ///

        return updatedResult;
    }
}