
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static bool MatchPrefixOperator(
        this Tokenizer<NeuToken> tokenizer) {
        
        return tokenizer.PeekPrefixOperator() is NeuPrefixOperator;
    }

    public static bool MatchInfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.PeekInfixOperator() is NeuInfixOperator;
    }

    public static bool MatchPostfixOperator(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.PeekPostfixOperator() is NeuPostfixOperator;
    }
}