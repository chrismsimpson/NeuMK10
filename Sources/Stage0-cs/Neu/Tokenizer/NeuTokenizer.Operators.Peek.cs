
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuOperator? PeekOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (true) {

            /// Prefix

            case var _ when tokenizer.PeekPrefixOperator() is NeuPrefixOperator prefixOp:

                return prefixOp;

            /// Infix or Postfix

            case var _ when tokenizer.PeekInfixOrPostfixOperator() is NeuOperator op:

                return op;

            ///

            default:

                return null;
        }
    }

    ///

    public static NeuOperator? PeekInfixOrPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (true) {

            /// Infix

            case var _ when tokenizer.PeekInfixOperator() is NeuInfixOperator infixOp:

                return infixOp;

            /// Postfix

            case var _ when tokenizer.PeekPostfixOperator() is NeuPostfixOperator postfixOp:

                return postfixOp;

            ///

            default:

                return null;
        }
    }

    ///

    public static NeuInfixOperator? PeekInfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        switch (true) {

            case var _ when tokenizer.PeekAssignOperator() is NeuAssignOperator assignOp:

                return assignOp;

            ///

            case var _ when tokenizer.PeekBinaryOperator() is NeuBinaryOperator binaryOp:

                return binaryOp;

            ///

            default:

                return null;
        }
    }
}
