
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuBinaryOperator? MaybeNextBinaryOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekBinaryOperator() is NeuBinaryOperator binaryOp) {

            tokenizer.Position++;

            ///

            return binaryOp;
        }

        ///

        return null;
    }
}
