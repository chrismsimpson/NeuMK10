
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuStatement ParseLabeledStatement(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var node = parser.ParseExpression();

        ///
        
        return parser.ParseExpressionStatement(start, node);
    }
}
