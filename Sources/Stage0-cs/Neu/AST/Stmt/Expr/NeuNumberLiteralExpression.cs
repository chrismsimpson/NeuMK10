
namespace Neu;

public partial class NeuNumberLiteralExpression: NeuExpression {

    public NeuNumberLiteralExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuNumberLiteralExpressionFunctions {

    public static NeuNumberLiteral? GetNumberLiteral(
        this NeuNumberLiteralExpression numberLiteralExpr) {

        return numberLiteralExpr.GetFirstOrDefault<NeuNumberLiteral>();
    }
}