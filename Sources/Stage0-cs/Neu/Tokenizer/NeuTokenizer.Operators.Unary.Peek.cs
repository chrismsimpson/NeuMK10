
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuUnaryOperator? PeekUnaryOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuPrefixOperator _:

                return null;

            ///

            case NeuPostfixOperator _:

                return null;

            ///

            case NeuUnaryOperator unaryOp:

                return unaryOp;

            ///

            case NeuToken t when ToNeuUnaryOperator(t) is NeuUnaryOperator unaryOp:

                tokenizer.Tokens[tokenizer.Position] = unaryOp;

                return unaryOp;

            ///

            default:

                return null;
        }
    }
}
