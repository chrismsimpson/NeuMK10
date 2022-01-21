
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuUnaryOperatorType? ToNeuUnaryOperatorType(
        NeuToken token) {

        switch (token) {

            case NeuKeyword k when k.KeywordType == NeuKeywordType.SizeOf:

                return NeuUnaryOperatorType.SizeOf;

            ///

            default:

                return null;
        }
    }

    public static NeuUnaryOperator? ToNeuUnaryOperator(
        NeuToken token) {

        switch (ToNeuUnaryOperatorType(token)) {

            case NeuUnaryOperatorType t:

                return new NeuUnaryOperator(
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
