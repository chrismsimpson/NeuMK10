
namespace MLIR;

public static partial class MLIRTokenizerFunctions {

    public static MLIRPunc? MaybeNextPunc(
        this Tokenizer<MLIRToken> tokenizer,
        MLIRPuncType puncType) {

        if (tokenizer.Peek() is MLIRPunc p && p.PuncType == puncType) {

            tokenizer.Position++;

            return p;
        }

        ///

        return null;
    }

    public static MLIRPunc? MaybeNextLeftParen(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(MLIRPuncType.LeftParen);
    }

    public static MLIRPunc? MaybeNextRightParen(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(MLIRPuncType.RightParen);
    }

    public static MLIRPunc? MaybeNextLeftBrace(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(MLIRPuncType.LeftBrace);
    }

    public static MLIRPunc? MaybeNextRightBrace(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextPunc(MLIRPuncType.RightBrace);
    }

    ///

    private static MLIRPunc NextPunc(
        this Tokenizer<MLIRToken> tokenizer,
        Char c,
        MLIRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next();

        if (next != c) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new MLIRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    private static MLIRPunc NextPunc(
        this Tokenizer<MLIRToken> tokenizer,
        String s,
        MLIRPuncType puncType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new MLIRPunc(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            puncType: puncType);
    }

    ///

    private static MLIRPunc NextLeftParen(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc('(', MLIRPuncType.LeftParen);
    }

    private static MLIRPunc NextRightParen(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc(')', MLIRPuncType.RightParen);
    }

    private static MLIRPunc NextLeftBrace(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc('{', MLIRPuncType.LeftBrace);
    }

    private static MLIRPunc NextRightBrace(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc('}', MLIRPuncType.RightBrace);
    }

    private static MLIRPunc NextLeftBracket(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc('[', MLIRPuncType.LeftBracket);
    }

    private static MLIRPunc NextRightBracket(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextPunc(']', MLIRPuncType.RightBracket);
    }
}