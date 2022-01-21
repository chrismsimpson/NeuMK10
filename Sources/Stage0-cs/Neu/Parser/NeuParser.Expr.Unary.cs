
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuUnaryExpression ParseUnaryExpression(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var op = parser.Tokenizer.MaybeNextUnaryOperator();

        if (op == null) {

            throw new Exception();
        }

        ///

        switch (op.OperatorType) {

            case NeuUnaryOperatorType.SizeOf:

                return parser.ParseSizeOfExpression(start, op);

            ///

            default:

                throw new Exception();
        }
    }
}