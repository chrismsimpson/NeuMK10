
namespace MLIR;

public static partial class MLIRTokenizerFunctions {

    public static MLIRKeyword? MaybeNextKeyword(
        this Tokenizer<MLIRToken> tokenizer,
        MLIRKeywordType keywordType) {

        if (tokenizer.Peek() is MLIRKeyword k && k.KeywordType == keywordType) {

            tokenizer.Position++;

            return k;
        }

        ///

        return null;
    }

    public static MLIRKeyword? MaybeNextFunc(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(MLIRKeywordType.Func);
    }

    public static MLIRKeyword? MaybeNextReturn(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(MLIRKeywordType.Return);
    }

    ///

    private static MLIRKeyword NextKeyword(
        this Tokenizer<MLIRToken> tokenizer,
        String s,
        MLIRKeywordType keywordType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new MLIRKeyword(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            keywordType: keywordType);
    }
    
    ///

    private static MLIRKeyword NextFunc(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextKeyword("func", MLIRKeywordType.Func);
    }

    private static MLIRKeyword NextReturn(
        this Tokenizer<MLIRToken> tokenizer) {

        return tokenizer.NextKeyword("return", MLIRKeywordType.Return);
    }
}