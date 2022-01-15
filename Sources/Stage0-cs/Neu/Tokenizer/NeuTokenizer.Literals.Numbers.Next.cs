
namespace Neu;

public partial class NeuTokenizer {

    public static bool IsNumberLiteralStart(
        Char c) {

        return c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.';
    }

    public static bool IsNumberLiteralPart(
        Char c) {
            
        return c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '.';
    }
}

///

public static partial class NeuTokenizerFunctions {

    public static NeuNumberLiteral? MaybeNextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer) {

        if (tokenizer.Peek() is NeuNumberLiteral n) {

            tokenizer.Position++;

            return n;
        }

        ///

        return null;
    }

    ///

    private static NeuNumberLiteral NextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer) {

        var start = tokenizer.Scanner.GetLocation();

        ///

        var next = tokenizer.Scanner.NextWhile(c => IsNumberLiteralPart(c));

        ///

        tokenizer.Scanner.NextWhitespace();

        ///

        return tokenizer.NextNumberLiteral(start, next);
    }

    private static (NeuToken? Token, int? Position) ReverseWalkNextNonCommentToken(
        this Tokenizer<NeuToken> tokenizer,
        int pos) {

        while (pos >= 0) {

            var t = tokenizer.Tokens.ElementAt(pos);

            ///

            switch (t) {

                case NeuComment _:

                    break;

                ///

                default:

                    return (t, pos);
            }

            ///

            pos--;
        }

        ///

        return (null, null);
    }

    private static NeuIdentifier? ReverseWalkFunctionReturnType(
        this Tokenizer<NeuToken> tokenizer,
        int startPos) {

        var pos = startPos;

        ///

        var (tokenDistance2, tokenDistance2Pos) = tokenizer.ReverseWalkNextNonCommentToken(pos);

        var p2 = tokenDistance2 as NeuPunc;

        if (p2 == null || p2.PuncType != NeuPuncType.LeftBrace || tokenDistance2Pos == null) {

            return null;
        }

        ///

        var (tokenDistance3, tokenDistance3Pos) = tokenizer.ReverseWalkNextNonCommentToken(tokenDistance2Pos.Value - 1);

        var id3 = tokenDistance3 as NeuIdentifier;

        if (id3 == null || tokenDistance3Pos == null) {

            return null;
        }

        ///

        var (tokenDistance4, tokenDistance4Pos) = tokenizer.ReverseWalkNextNonCommentToken(tokenDistance3Pos.Value - 1);

        var p4 = tokenDistance4 as NeuPunc;

        if (p4 == null || p4.PuncType != NeuPuncType.Arrow || tokenDistance4Pos == null) {

            return null;
        }

        ///

        return id3;
    }

    private static NeuNumberLiteral NextNumberLiteral(
        this Tokenizer<NeuToken> tokenizer,
        SourceLocation start,
        String source) {

        var pos = tokenizer.Position - 1;

        ///

        var (tokenDistance1, tokenDistance1Pos) = tokenizer.ReverseWalkNextNonCommentToken(pos);

        ///

        String? type = null;

        ///

        switch (true) {

            case var _ 
                when 
                    tokenDistance1 is NeuKeyword k1 && k1.KeywordType == NeuKeywordType.Return &&
                    tokenDistance1Pos is int p1:
                    
                var id = tokenizer.ReverseWalkFunctionReturnType(p1 - 1);

                switch (id) {

                    case NeuIdentifier i when i.Source == "Int":

                        type = "Int";

                        break;

                    ///

                    case NeuIdentifier i when i.Source == "Float":

                        type = "Float";

                        break;
                    
                    ///

                    default:

                        break;
                }

                ///

                break;


            ///

            case var _ 
                when
                    tokenDistance1 is NeuBinaryOperator b1 &&
                    tokenDistance1Pos is int p1:

                var (tokenDistance2, tokenDistance2Pos) = tokenizer.ReverseWalkNextNonCommentToken(p1 - 1);

                switch (tokenDistance2) {

                    case NeuIntegerLiteral _ when tokenDistance2Pos is int:

                        type = "Int";

                        break;

                    ///

                    case NeuFloatLiteral _ when tokenDistance2Pos is int:

                        type = "Float";

                        break;

                    ///

                    default:

                        break;
                }

                ///

                break;

            ///

            default:

                break;
        }

        ///

        switch (type) {

            case "Int":

                int intValue = 0;

                if (!int.TryParse(source, out intValue)) {
                    
                    throw new Exception();
                }

                ///

                return new NeuIntegerLiteral(
                    source: source,
                    start: start,
                    end: tokenizer.GetLocation(),
                    value: intValue);

            ///

            case "Float":

                float floatValue = 0;

                if (!float.TryParse(source, out floatValue)) {

                    throw new Exception();
                }

                ///

                return new NeuFloatLiteral(
                    source: source,
                    start: start,
                    end: tokenizer.GetLocation(),
                    value: floatValue);

            ///

            default:

                throw new Exception();
        }
    }
}
