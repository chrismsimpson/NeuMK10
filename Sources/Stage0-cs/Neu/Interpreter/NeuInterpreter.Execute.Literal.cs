
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
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

    public static NeuValue Execute(
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

    // public static NeuValue Execute(
    //     this NeuInterpreter interpreter,
    //     Node node) {

    //     switch (node) {
            
    //         case NeuExpression e:
    //             return interpreter.Execute(e);

    //         ///

    //         case NeuIdentifier i:
    //             return interpreter.Execute(i);

    //         ///

    //         case NeuLiteral l:
    //             return interpreter.Execute(l);

    //         ///

    //         // case NeuVariableDeclarator d:
    //         //     return interpreter.Execute(d);

    //         ///

    //         default:
    //             throw new Exception();
    //     }
    // }
}
