
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static bool MatchPrefixOperator(
        this Tokenizer<NeuToken> tokenizer) {
        
        return tokenizer.PeekOperator() is NeuOperator;
    }

    public static bool MatchInfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.PeekInfixOperator() is NeuInfixOperator;
    }

    public static bool MatchPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.PeekPostfixOperator() is NeuPostfixOperator;
    }

    // public static bool MatchInfixOrPostfixOperator(
    //     this Tokenizer<NeuToken> tokenizer) {

    //     return tokenizer.PeekInfixOrPostfixOperator() is NeuOperator;
    // }
}