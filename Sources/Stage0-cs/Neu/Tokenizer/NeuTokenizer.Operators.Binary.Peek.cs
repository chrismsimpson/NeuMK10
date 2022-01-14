
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuBinaryOperator? PeekBinaryOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuBinaryOperator bo:

                return bo;

            ///

            case NeuToken t when ToNeuBinaryOperator(t) is NeuBinaryOperator bo:

                tokenizer.Tokens[tokenizer.Position] = bo;

                return bo;

            ///

            default:

                return null;
        }
    }
}
