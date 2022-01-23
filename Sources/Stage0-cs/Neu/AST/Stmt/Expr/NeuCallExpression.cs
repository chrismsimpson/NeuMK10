
namespace Neu;

public partial class NeuCallExpression: NeuExpression {

    public NeuCallExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuCallExpressionFunctions {

    public static NeuIdentifierExpression? GetIdentifierExpression(
        this NeuCallExpression callExpr) {

        return callExpr.GetFirstOrDefault<NeuIdentifierExpression>();
    }

    public static NeuIdentifier? GetIdentifier(
        this NeuCallExpression callExpr) {

        return callExpr
            .GetIdentifierExpression()?
            .GetIdentifier();
    }

    public static String? GetName(
        this NeuCallExpression callExpr) {

        return callExpr.GetIdentifier()?.Source;
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
