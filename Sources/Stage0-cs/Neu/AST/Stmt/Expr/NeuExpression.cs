
namespace Neu;

public partial class NeuExpression: NeuStatement {

    public NeuExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuExpressionFunctions {

    public static NeuIdentifier? GetIdentifier(
        this NeuExpression expr) {

        switch (expr) {

            case NeuIdentifierExpression idExpr:

                return idExpr.GetIdentifier();

            ///

            default:

                return null;
        }
    }
}