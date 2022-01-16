
namespace Neu;

public static partial class NeuTokenizerFunctions {

    public static NeuToken? MaybeNext(
        this Tokenizer<NeuToken> tokenizer) {

        var peek = tokenizer.Peek();

        if (peek != null) {

            tokenizer.Position++;
        }

        return peek;
    }

    ///

    private static NeuToken? Next(
        this Tokenizer<NeuToken> tokenizer) {

        while (!tokenizer.Scanner.IsEof()) {
        
            var peek = tokenizer.Scanner.Peek();

            ///

            switch (peek) {

                /// Skip over whitespace

                case Char c when IsWhiteSpace(c):

                    tokenizer.Scanner.Position++;

                    break;



                /// Comments

                case '/' when tokenizer.Scanner.Match(equals: '/', distance: 1):
                    return tokenizer.NextLineEndComment();

                case '/' when tokenizer.Scanner.Match(equals: '*', distance: 1):
                    return tokenizer.NextInlineComment();


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


                    /// Binary Operators (punc)

                case '=':
                    return tokenizer.NextEqual();

                case '*':
                    return tokenizer.NextAsterisk();

                case '/':
                    return tokenizer.NextSlash();

                case '+':
                    return tokenizer.NextPlus();

                case '-':
                    return tokenizer.NextHyphen();



                /// Keywords

                case 'f' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "unc", distance: 1):
                    return tokenizer.NextFunc();

                case 'r' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "eturn", distance: 1):
                    return tokenizer.NextReturn();

                case 'v' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "ar", distance: 1):
                    return tokenizer.NextVar();

                case 'l' when tokenizer.Scanner.MatchWithTrailingWhitespace(equals: "et", distance: 1):
                    return tokenizer.NextLet();


                
                /// Literals - Numbers

                case Char c when IsNumberLiteralStart(c):
                    return tokenizer.NextNumberLiteral();



                /// Identifiers

                case Char c when IsNeuIdentifierStart(c):
                    return tokenizer.NextIdentifier();




                case var t:
                    throw new Exception($"Unexpected: {t}");
            }
        }

        ///

        return null;
    }
}