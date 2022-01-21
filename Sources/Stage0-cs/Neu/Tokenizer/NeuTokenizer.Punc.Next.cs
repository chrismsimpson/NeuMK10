
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuPunc? MaybeNextPunc(
        this Tokenizer<NeuToken> tokenizer,
        NeuPuncType puncType) {

        if (tokenizer.Peek() is NeuPunc p && p.PuncType == puncType) {

            tokenizer.Position++;

            return p;
        }

        ///

        return null;
    }

    public static NeuPunc? MaybeNextArrow(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Arrow);
    }

    public static NeuPunc? MaybeNextLeftParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.LeftParen);
    }

    public static NeuPunc? MaybeNextRightParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.RightParen);
    }

    public static NeuPunc? MaybeNextLeftBrace(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.LeftBrace);
    }

    public static NeuPunc? MaybeNextRightBrace(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.RightBrace);
    }

    public static NeuPunc? MaybeNextLeftBracket(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.LeftBracket);
    }

    public static NeuPunc? MaybeNextRightBracket(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.RightBracket);
    }

    public static NeuPunc? MaybeNextColon(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Colon);
    }

    public static NeuPunc? MaybeNextSemicolon(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Semicolon);
    }

    public static NeuPunc? MaybeNextComma(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Comma);
    }

    public static NeuPunc? MaybeNextEqual(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Equal);
    }

    public static NeuPunc? MaybeNextLess(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Less);
    }

    public static NeuPunc? MaybeNextGreater(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextPunc(NeuPuncType.Greater);
    }

    ///

    private static NeuPunc NextPunc(
        this Tokenizer<NeuToken> tokenizer,
        Char c,
        NeuPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    private static NeuPunc NextPunc(
        this Tokenizer<NeuToken> tokenizer,
        String s,
        NeuPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    ///

    private static NeuPunc NextArrow(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc("->", NeuPuncType.Arrow);
    }

    private static NeuPunc NextLeftParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('(', NeuPuncType.LeftParen);
    }

    private static NeuPunc NextRightParen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc(')', NeuPuncType.RightParen);
    }

    private static NeuPunc NextLeftBrace(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('{', NeuPuncType.LeftBrace);
    }

    private static NeuPunc NextRightBrace(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('}', NeuPuncType.RightBrace);
    }

    private static NeuPunc NextLeftBracket(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('[', NeuPuncType.LeftBracket);
    }

    private static NeuPunc NextRightBracket(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc(']', NeuPuncType.RightBracket);
    }

    private static NeuPunc NextColon(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc(':', NeuPuncType.Colon);
    }

    private static NeuPunc NextSemicolon(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc(';', NeuPuncType.Semicolon);
    }

    private static NeuPunc NextComma(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc(',', NeuPuncType.Comma);
    }

    private static NeuPunc NextEqual(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('=', NeuPuncType.Equal);
    }

    private static NeuPunc NextAsterisk(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('*', NeuPuncType.Asterisk);
    }

    private static NeuPunc NextSlash(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('/', NeuPuncType.Slash);
    }

    private static NeuPunc NextPlus(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('+', NeuPuncType.Plus);
    }

    private static NeuPunc NextHyphen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('-', NeuPuncType.Hyphen);
    }

    private static NeuPunc NextPlusPlus(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc("++", NeuPuncType.PlusPlus);
    }

    private static NeuPunc NextHyphenHyphen(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc("--", NeuPuncType.HyphenHyphen);
    }

    private static NeuPunc NextLess(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('<', NeuPuncType.Less);
    }

    private static NeuPunc NextGreater(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextPunc('>', NeuPuncType.Greater);
    }
}