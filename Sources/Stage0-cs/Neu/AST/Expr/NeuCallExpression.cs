
namespace Neu;

public partial class NeuCallExpression: NeuExpression {

    public NeuCallExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuCallExpressionFunctions {

    public static IEnumerable<Node> GetArguments(
        this NeuCallExpression callExpr) {

        var insideParen = false;

        var done = false;

        ///

        foreach (var child in callExpr.Children) {

            if (done) {

                break;
            }

            ///

            switch (child) {

                case NeuPunc p when p.PuncType == NeuPuncType.LeftParen:

                    insideParen = true;

                    break;

                ///

                case NeuPunc p when p.PuncType == NeuPuncType.RightParen:

                    insideParen = false;

                    done = true;

                    break;

                ///

                case var _ when insideParen:

                    yield return child;

                    break;

                ///

                default:

                    continue;
            }
        } 
    }
}
