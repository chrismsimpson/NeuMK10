
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuArrayExpression NeuArrayExpression(
        this NeuParser parser,
        SourceLocation start) {

        var children = new List<Node>();

        ///

        var leftBracket = parser.Tokenizer.MaybeNextLeftBracket();

        if (leftBracket == null) {

            throw new Exception();
        }

        children.Add(leftBracket);

        ///

        var arrayElementList = parser.ParseArrayElementList();

        children.Add(arrayElementList);

        ///

        var rightBracket = parser.Tokenizer.MaybeNextRightBracket();

        if (rightBracket == null) {

            throw new Exception();
        }

        children.Add(rightBracket);

        ///

        return new NeuArrayExpression(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static NeuArrayElementList ParseArrayElementList(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var elements = parser.ParseArrayElements();

        ///

        return new NeuArrayElementList(
            children: elements,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<NeuArrayElement> ParseArrayElements(
        this NeuParser parser) {

        var elements = new List<NeuArrayElement>();

        ///
        
        while (!parser.Tokenizer.IsEof()) {

            if (parser.Tokenizer.MatchRightBracket()) {

                break;
            }

            ///

            var element = parser.ParseArrayElement();

            elements.Add(element);
        }

        ///

        return elements;
    }

    public static NeuArrayElement ParseArrayElement(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var expr = parser.ParseExpression();

        children.Add(expr);

        ///

        if (parser.Tokenizer.MaybeNextComma() is NeuPunc comma) {

            children.Add(comma);
        }

        ///

        return new NeuArrayElement(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
