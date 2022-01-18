
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuLiteral literal) {

        switch (literal) {

            case NeuNumberLiteral numberLiteral:
                return interpreter.Execute(numberLiteral);

            ///

            default:
                throw new Exception();
        }
    }

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuNumberLiteral numberLiteral) {

        switch (numberLiteral) {

            case NeuFloatLiteral floatLiteral:

                return new NeuFloat(floatLiteral.Value);

            ///

            case NeuIntegerLiteral integerLiteral:

                return new NeuInteger(integerLiteral.Value);

            ///

            default:

                throw new Exception();
        }
    }
}
