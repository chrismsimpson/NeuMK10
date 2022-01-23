
namespace Neu;

public partial class NeuNumberLiteralExpression: NeuLiteralExpression {

    public NeuNumberLiteralExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuNumberLiteralExpressionFunctions {

    public static NeuNumberLiteral? GetNumberLiteral(
        this NeuNumberLiteralExpression numberLiteralExpr) {

        return numberLiteralExpr.GetFirstOrDefault<NeuNumberLiteral>();
    }
}