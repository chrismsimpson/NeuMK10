
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static bool MatchPunc(
        this Tokenizer<NeuToken> tokenizer,
        params NeuPuncType[] puncTypes) {

        if (tokenizer.Peek() is NeuPunc p && puncTypes.Contains(p.PuncType)) {

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

    public static bool MatchSemicolon(
        this Tokenizer<NeuToken> tokenizer) {
            
        return tokenizer.MatchPunc(NeuPuncType.Semicolon);
    }

    public static bool MatchSemicolonOrRightBrace(
        this Tokenizer<NeuToken> tokenizer) {
            
        return tokenizer.MatchPunc(NeuPuncType.Semicolon, NeuPuncType.RightBrace);
    }

    public static bool MatchColon(
        this Tokenizer<NeuToken> tokenizer) {
            
        return tokenizer.MatchPunc(NeuPuncType.Colon);
    }

    public static bool MatchEqual(
        this Tokenizer<NeuToken> tokenizer) {
            
        return tokenizer.MatchPunc(NeuPuncType.Equal);
    }

    public static bool MatchLess(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.Less);
    }

    public static bool MatchGreater(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.Greater);
    }

    public static bool MatchRightBracket(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MatchPunc(NeuPuncType.RightBracket);
    }

}
