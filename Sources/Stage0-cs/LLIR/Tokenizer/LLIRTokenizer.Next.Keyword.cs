
namespace LLIR;

public static partial class LLIRTokenizerFunctions {

    public static LLIRKeyword? MaybeNextKeyword(
        this Tokenizer<LLIRToken> tokenizer,
        LLIRKeywordType keywordType) {

        if (tokenizer.Peek() is LLIRKeyword k && k.KeywordType == keywordType) {

            tokenizer.Position++;

            return k;
        }

        ///

        return null;
    }

    public static LLIRKeyword? MaybeNextDefine(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(LLIRKeywordType.Define);
    }

    public static LLIRKeyword? MaybeNextRet(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(LLIRKeywordType.Ret);
    }

    ///

    private static LLIRKeyword NextKeyword(
        this Tokenizer<LLIRToken> tokenizer,
        String s,
        LLIRKeywordType keywordType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new LLIRKeyword(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            keywordType: keywordType);
    }
    
    ///

    private static LLIRKeyword NextDefine(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextKeyword("define", LLIRKeywordType.Define);
    }

    private static LLIRKeyword NextRet(
        this Tokenizer<LLIRToken> tokenizer) {

        return tokenizer.NextKeyword("ret", LLIRKeywordType.Ret);
    }
}