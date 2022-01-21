
namespace Neu;

public partial class NeuUnaryExpression: NeuExpression {

    public NeuUnaryExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuUnaryExpressionFunctions {

    public static bool IsFixExpression(
        this NeuUnaryExpression unaryExpression) {

        switch (unaryExpression) {

            case NeuPrefixExpression _:

                return true;

            ///

            case NeuPostfixExpression _:
            
                return true;

            ///

            default:

                return false;
        }
    }
}