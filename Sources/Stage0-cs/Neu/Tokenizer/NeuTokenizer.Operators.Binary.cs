
namespace Neu;

public partial class NeuTokenizer {

    public static NeuBinaryOperatorType? ToNeuBinaryOperatorType(
        NeuToken token) {

        switch (token) {

            case NeuPunc p when p.PuncType == NeuPuncType.Asterisk:

                return NeuBinaryOperatorType.Multiply;

            ///

            case NeuPunc p when p.PuncType == NeuPuncType.Slash:

                return NeuBinaryOperatorType.Divide;

            ///

            case NeuPunc p when p.PuncType == NeuPuncType.Plus:

                return NeuBinaryOperatorType.Add;

            ///

            case NeuPunc p when p.PuncType == NeuPuncType.Hyphen:

                return NeuBinaryOperatorType.Subtract;

            ///

            default:

                return null;
        }
    }

    public static NeuBinaryOperator? ToNeuBinaryOperator(
        NeuToken token) {

        switch (ToNeuBinaryOperatorType(token)) {

            case NeuBinaryOperatorType t:

                return new NeuBinaryOperator(
                    source: token.Source,
                    start: token.Start,
                    end: token.End,
                    operatorType: t);

            ///

            default:

                return null;
        }
    }
}
