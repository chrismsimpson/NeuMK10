
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuKeyword? MaybeNextKeyword(
        this Tokenizer<NeuToken> tokenizer,
        params NeuKeywordType[] keywordTypes) {

        if (tokenizer.Peek() is NeuKeyword k && keywordTypes.Contains(k.KeywordType)) {

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

    public static NeuKeyword? MaybeNextLetOrVar(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(NeuKeywordType.Let, NeuKeywordType.Var);
    }

    public static NeuKeyword? MaybeNextTrueOrFalse(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.MaybeNextKeyword(NeuKeywordType.True, NeuKeywordType.False);
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

    private static NeuKeyword NextVar(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("var", NeuKeywordType.Var);
    }

    private static NeuKeyword NextLet(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("let", NeuKeywordType.Let);
    }

    private static NeuKeyword NextTrue(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("true", NeuKeywordType.True);
    }

    private static NeuKeyword NextFalse(
        this Tokenizer<NeuToken> tokenizer) {

        return tokenizer.NextKeyword("false", NeuKeywordType.False);
    }
}