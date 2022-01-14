
namespace IR;

public static partial class IRTokenizerFunctions {

    public static IRKeyword? MaybeNextKeyword(
        this Tokenizer<IRToken> tokenizer,
        IRKeywordType keywordType) {

        if (tokenizer.Peek() is IRKeyword k && k.KeywordType == keywordType) {

            tokenizer.Position++;

            return k;
        }

        ///

        return null;
    }

    public static IRKeyword? MaybeNextFunc(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(IRKeywordType.Func);
    }

    public static IRKeyword? MaybeNextReturn(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(IRKeywordType.Return);
    }

    ///

    private static IRKeyword NextKeyword(
        this Tokenizer<IRToken> tokenizer,
        String s,
        IRKeywordType keywordType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new IRKeyword(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            keywordType: keywordType);
    }
    
    ///

    private static IRKeyword NextFunc(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextKeyword("func", IRKeywordType.Func);
    }

    private static IRKeyword NextReturn(
        this Tokenizer<IRToken> tokenizer) {

        return tokenizer.NextKeyword("return", IRKeywordType.Return);
    }
}