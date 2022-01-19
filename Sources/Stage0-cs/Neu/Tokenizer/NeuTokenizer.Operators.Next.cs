
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuOperator? MaybeNextOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekOperator() is NeuOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }

    ///

    public static NeuInfixOperator? MaybeNextInfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekInfixOperator() is NeuInfixOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }

    ///

    public static NeuPostfixOperator? MaybeNextPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.PeekPostfixOperator() is NeuPostfixOperator op) {

            tokenizer.Position++;

            return op;
        }

        ///

        return null;
    }

    // public static NeuOperator? MaybeNextInfixOrPostfixOperator(
    //     this Tokenizer<NeuToken> tokenizer) {

    //     if (tokenizer.PeekInfixOrPostfixOperator() is NeuOperator op) {

    //         tokenizer.Position++;

    //         return op;
    //     }

    //     ///

    //     return null;
    // }
}