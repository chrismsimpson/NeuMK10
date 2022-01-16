
namespace Neu;

public static partial class NeuParserHelpers {

    public static NeuTypeAnnotation ParseTypeAnnotation(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var colon = parser.Tokenizer.MaybeNextColon();

        if (colon == null) {

            throw new Exception();
        }

        children.Add(colon);

        ///

        var typeId = parser.ParseTypeIdentifier();

        children.Add(typeId);

        ///

        return new NeuTypeAnnotation(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    ///

    public static NeuNode ParseTypeIdentifier(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            case NeuIdentifier _:

                return parser.ParseSimpleTypeId();

            ///

            case NeuPunc p when p.PuncType == NeuPuncType.LeftParen:

                // tuple type

                throw new Exception();

            ///

            case var t:

                throw new Exception($"Unexpected: {t}");
        }
    }

    // public static NeuNode ParseTypeIdentifier(
    //     this NeuParser parser) {

    //     var start = parser.Tokenizer.GetLocation();

    //     ///

    //     switch (parser.Tokenizer.Peek()) {

    //         case 
    //     }

    //     // var token = parser.Tokenizer.MaybeNext();

    //     // if (token == null)
    //     // {
    //     //     throw new Exception();
    //     // }   

    //     // ///

    //     // return parser.ParseTypeIdentifier(start, token);
    // }
}
