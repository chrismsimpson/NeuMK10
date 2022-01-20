
namespace Neu;

public partial class NeuIdentifierExpression: NeuExpression {

    public NeuIdentifierExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuNumberLiteralExpressionFunctions {

    public static NeuIdentifier? GetIdentifier(
        this NeuIdentifierExpression idExpr) {

        return idExpr.GetFirstOrDefault<NeuIdentifier>();
    }
}