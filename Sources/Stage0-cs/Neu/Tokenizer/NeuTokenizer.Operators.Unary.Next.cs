
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuUnaryOperator? MaybeNextUnaryOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekUnaryOperator() is NeuUnaryOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }
}
