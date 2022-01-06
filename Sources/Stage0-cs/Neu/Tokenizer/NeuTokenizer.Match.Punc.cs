
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static bool MatchPunc(
        this Tokenizer<NeuToken> tokenizer,
        params NeuPuncType[] puncType) {

        if (tokenizer.Peek() is NeuPunc p && puncType.Contains(p.PuncType)) {

            return true;
        }

        ///

        return false;
    }

    ///

    public static bool MatchArrow(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.Arrow);
    }

    public static bool MatchLeftParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.LeftParen);
    }

    public static bool MatchRightParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.RightParen);
    }

    public static bool MatchRightBrace(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.RightBrace);
    }

    public static bool MatchComma(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.Comma);
    }
}
