
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

    public static String? GetName(
        this NeuCallExpression callExpr) {

        return callExpr.GetFirstOrDefault<NeuIdentifier>()?.Source;
    }

    public static IEnumerable<Node> GetArguments(
        this NeuCallExpression callExpr) {

        var args = new List<Node>();

        ///

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

                    args.Add(child);

                    // yield return child;

                    break;

                ///

                default:

                    continue;
            }
        } 
            
        ///

        return args;
    }
}
