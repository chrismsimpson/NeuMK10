
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuPostfixOperator? PeekPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuPostfixOperator postfixOp:

                return postfixOp;

            ///

            case NeuToken t when ToNeuPostfixOperator(t) is NeuPostfixOperator postfixOp:

                tokenizer.Tokens[tokenizer.Position] = postfixOp;

                return postfixOp;

            ///

            default:
            
                return null;
        }
    }
}
