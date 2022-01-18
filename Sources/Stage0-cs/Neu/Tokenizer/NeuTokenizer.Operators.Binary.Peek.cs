
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuBinaryOperator? PeekBinaryOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuBinaryOperator binaryOp:

                return binaryOp;

            ///

            case NeuToken t when ToNeuBinaryOperator(t) is NeuBinaryOperator binaryOp:

                tokenizer.Tokens[tokenizer.Position] = binaryOp;

                return binaryOp;

            ///

            default:

                return null;
        }
    }
}
