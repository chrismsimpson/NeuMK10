
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuAssignOperator? PeekAssignOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuAssignOperator assignOp:

                return assignOp;

            ///

            case NeuToken t when ToNeuAssignOperator(t) is NeuAssignOperator assignOp:

                tokenizer.Tokens[tokenizer.Position] = assignOp;

                return assignOp;

            ///

            default:

                return null;
        }
    }
}
