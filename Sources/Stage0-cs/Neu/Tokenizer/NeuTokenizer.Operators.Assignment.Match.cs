
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static bool MatchAssignmentOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (tokenizer.Peek()) {

            case NeuAssignmentOperator op:

                return true;

            ///

            case NeuToken t when ToAssignmentOperator(t) is NeuAssignmentOperator op:

                tokenizer.Tokens[tokenizer.Position] = op;

                return true;

            ///

            default:

                return false;
        }
    }
}
