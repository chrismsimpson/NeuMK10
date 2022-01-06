
namespace Neu;

public partial class NeuTokenizer {

    public static bool IsIdentifierPart(
        Char c) {

        return c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F' || c == 'G' || c == 'H' || c == 'I' || c == 'J' || c == 'K' || c == 'L' || c == 'M' || c == 'N' || c == 'O' || c == 'P' || c == 'Q' || c == 'R' || c == 'S' || c == 'T' || c == 'U' || c == 'V' || c == 'W' || c == 'X' || c == 'Y' || c == 'Z' || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f' || c == 'g' || c == 'h' || c == 'i' || c == 'j' || c == 'k' || c == 'l' || c == 'm' || c == 'n' || c == 'o' || c == 'p' || c == 'q' || c == 'r' || c == 's' || c == 't' || c == 'u' || c == 'v' || c == 'w' || c == 'x' || c == 'y' || c == 'z' || c == '_' || c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9';
    }

    public static bool IsIdentifierStart(
        Char c) {

        return c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F' || c == 'G' || c == 'H' || c == 'I' || c == 'J' || c == 'K' || c == 'L' || c == 'M' || c == 'N' || c == 'O' || c == 'P' || c == 'Q' || c == 'R' || c == 'S' || c == 'T' || c == 'U' || c == 'V' || c == 'W' || c == 'X' || c == 'Y' || c == 'Z' || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f' || c == 'g' || c == 'h' || c == 'i' || c == 'j' || c == 'k' || c == 'l' || c == 'm' || c == 'n' || c == 'o' || c == 'p' || c == 'q' || c == 'r' || c == 's' || c == 't' || c == 'u' || c == 'v' || c == 'w' || c == 'x' || c == 'y' || c == 'z' || c == '_';
    }
}

///

public static partial class NeuTokenizerFunctions {

    public static NeuIdentifier? MaybeNextIdentifier(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Peek() is NeuIdentifier i) {

            tokenizer.Position++;
            
            return i;
        }

        ///

        return null;
    }

    ///

    private static NeuIdentifier NextIdentifier(
        this Tokenizer<NeuToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var source = tokenizer.Scanner.NextWhile(c => IsIdentifierPart(c));

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return new NeuIdentifier(
            source: source,
            start: start,
            end: tokenizer.Scanner.GetLocation());
    }
}
