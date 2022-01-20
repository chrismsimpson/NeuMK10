
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuUnaryOperatorType? ToNeuPrefixOperatorType(
        NeuToken token) {

        switch (token) {

            case NeuPunc p when p.PuncType == NeuPuncType.PlusPlus:

                return NeuUnaryOperatorType.Increment;

            ///

            case NeuPunc p when p.PuncType == NeuPuncType.HyphenHyphen:

                return NeuUnaryOperatorType.Decrement;

            ///

            default:

                return null;
        }
    }

    public static NeuPrefixOperator? ToNeuPrefixOperator(
        NeuToken token) {

        switch (ToNeuPostfixOperatorType(token)) {

            case NeuUnaryOperatorType t:

                return new NeuPrefixOperator(
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
