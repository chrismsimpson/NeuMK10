
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuPrefixOperator? MaybeNextPrefixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekPrefixOperator() is NeuPrefixOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }
}
