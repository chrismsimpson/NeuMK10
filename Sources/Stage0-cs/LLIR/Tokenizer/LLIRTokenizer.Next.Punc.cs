
namespace LLIR;

public static partial class LLIRTokenizerFunctions {

    public static LLIRPunc? MaybeNextPunc(
        this Tokenizer<LLIRToken> tokenizer,
        LLIRPuncType puncType) {

        if (tokenizer.Peek() is LLIRPunc p && p.PuncType == puncType) {

            tokenizer.Position++;

            return p;
        }

        ///

        return null;
    }

    public static LLIRPunc? MaybeNextLeftParen(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(LLIRPuncType.LeftParen);
    }

    public static LLIRPunc? MaybeNextRightParen(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(LLIRPuncType.RightParen);
    }

    public static LLIRPunc? MaybeNextLeftBrace(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(LLIRPuncType.LeftBrace);
    }

    public static LLIRPunc? MaybeNextRightBrace(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(LLIRPuncType.RightBrace);
    }

    ///

    private static LLIRPunc NextPunc(
        this Tokenizer<LLIRToken> tokenizer,
        Char c,
        LLIRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new LLIRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    private static LLIRPunc NextPunc(
        this Tokenizer<LLIRToken> tokenizer,
        String s,
        LLIRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new LLIRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    ///

    private static LLIRPunc NextLeftParen(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc('(', LLIRPuncType.LeftParen);
    }

    private static LLIRPunc NextRightParen(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc(')', LLIRPuncType.RightParen);
    }

    private static LLIRPunc NextLeftBrace(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc('{', LLIRPuncType.LeftBrace);
    }

    private static LLIRPunc NextRightBrace(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc('}', LLIRPuncType.RightBrace);
    }

    private static LLIRPunc NextLeftBracket(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc('[', LLIRPuncType.LeftBracket);
    }

    private static LLIRPunc NextRightBracket(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextPunc(']', LLIRPuncType.RightBracket);
    }
}