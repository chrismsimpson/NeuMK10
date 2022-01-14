
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuKeyword? MaybeNextKeyword(
        this Tokenizer<NeuToken> tokenizer,
        NeuKeywordType keywordType) {

        if (tokenizer.Peek() is NeuKeyword k && k.KeywordType == keywordType) {

            tokenizer.Position++;

            return k;
        }

        ///

        return null;
    }

    public static NeuKeyword? MaybeNextFunc(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(NeuKeywordType.Func);
    }

    public static NeuKeyword? MaybeNextReturn(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(NeuKeywordType.Return);
    }

    ///

    private static NeuKeyword NextKeyword(
        this Tokenizer<NeuToken> tokenizer,
        String s,
        NeuKeywordType keywordType) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.Next(s.Length);

        if (next != s) {

            throw new Exception();
        }

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuKeyword(
            source: next,
            start: start,
            end: tokenizer.Scanner.GetLocation(),
            keywordType: keywordType);
    }
    
    ///

    private static NeuKeyword NextFunc(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("func", NeuKeywordType.Func);
    }

    private static NeuKeyword NextReturn(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("return", NeuKeywordType.Return);
    }
}