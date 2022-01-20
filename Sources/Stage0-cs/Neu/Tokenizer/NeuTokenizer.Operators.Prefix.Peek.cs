
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuPrefixOperator? PeekPrefixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuPrefixOperator prefixOp:

                return prefixOp;

            ///

            case NeuToken t when ToNeuPrefixOperator(t) is NeuPrefixOperator prefixOp:

                tokenizer.Tokens[tokenizer.Position] = prefixOp;

                return prefixOp;

            ///

            default:

                return null;
        }
    }
}
