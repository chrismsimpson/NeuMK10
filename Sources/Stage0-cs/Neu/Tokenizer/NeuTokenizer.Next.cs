
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuToken? MaybeNext(
        this Tokenizer<NeuToken> tokenizer) {

        var peek = tokenizer.MaybePeek();

        if (peek != null) {

            tokenizer.Position++;
        }

        return peek;
    }

    ///

    private static NeuToken Next(
        this Tokenizer<NeuToken> tokenizer) {

        var peek = tokenizer.Scanner.Peek();

        ///

        switch (peek) {

            /// Arrow

            case '-' when tokenizer.Scanner.Match(equals: '>', distance: 1):
                return tokenizer.NextArrow();

            /// Punc

            case '(':
                return tokenizer.NextLeftParen();

            case ')':
                return tokenizer.NextRightParen();

            case '{':
                return tokenizer.NextLeftBrace();

            case '}':
                return tokenizer.NextRightBrace();

            case '[':
                return tokenizer.NextLeftBracket();

            case ']':
                return tokenizer.NextRightBracket();

            case ':':
                return tokenizer.NextColon();

            case ';':
                return tokenizer.NextSemicolon();

            case ',':
                return tokenizer.NextComma();



            /// Keywords

            case 'f' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "unc", distance: 1):
                return tokenizer.NextFunc();

            case 'r' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "eturn", distance: 1):
                return tokenizer.NextReturn();



            /// Identifiers

            case Char c when IsIdentifierStart(c):
                return tokenizer.NextIdentifier();




            default:
                throw new Exception();
        }
    }
}