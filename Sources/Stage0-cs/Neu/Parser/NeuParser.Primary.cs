
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParsePrimary(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        switch (parser.Tokenizer.Peek()) {

            case NeuIdentifier _:

                // TODO: Optimize w ++

                var id = parser.Tokenizer.MaybeNextIdentifier();

                if (id == null) {

                    throw new Exception();
                }

                // return id;
                return parser.ParseIdentifierExpression(start, id);

            ///

            case NeuNumberLiteral _:

                // TODO: Optimize w ++
                
                var number = parser.Tokenizer.MaybeNextNumberLiteral();

                if (number == null) {

                    throw new Exception();
                }

                // return number;
                return parser.ParseNumberLiteralExpression(start, number);

            ///

            case NeuKeyword k when k.KeywordType == NeuKeywordType.True || k.KeywordType == NeuKeywordType.False:

                var boolKeyword = parser.Tokenizer.MaybeNextTrueOrFalse();

                if (boolKeyword == null) {

                    throw new Exception();
                }

                ///

                return parser.ParseBoolLiteralExpression(start, boolKeyword);

            ///

            case var t:

                throw new Exception($"Unexpected: {t}");
        }
    }

    public static NeuIdentifierExpression ParseIdentifierExpression(
        this NeuParser parser,
        ISourceLocation start,
        NeuIdentifier id) {

        return new NeuIdentifierExpression(
            children: new Node[] { id },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static NeuNumberLiteralExpression ParseNumberLiteralExpression(
        this NeuParser parser,
        ISourceLocation start,
        NeuNumberLiteral lit) {

        return new NeuNumberLiteralExpression(
            children: new Node[] { lit },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static NeuBoolLiteralExpression ParseBoolLiteralExpression(
        this NeuParser parser,
        ISourceLocation start,
        NeuKeyword boolKeyword) {

        return new NeuBoolLiteralExpression(
            children: new Node[] { boolKeyword },
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
