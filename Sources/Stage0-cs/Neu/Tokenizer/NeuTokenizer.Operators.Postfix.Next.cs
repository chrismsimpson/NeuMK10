
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuPostfixOperator? MaybeNextPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekPostfixOperator() is NeuPostfixOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }
}
