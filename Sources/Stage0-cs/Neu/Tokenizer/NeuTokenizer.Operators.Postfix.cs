
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuUnaryOperatorType? ToNeuPostfixOperatorType(
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

    public static NeuPostfixOperator? ToNeuPostfixOperator(
        NeuToken token) {

        switch (ToNeuPostfixOperatorType(token)) {

            case NeuUnaryOperatorType t:

                return new NeuPostfixOperator(
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
