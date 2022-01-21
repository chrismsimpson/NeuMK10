
namespace Neu;

public partial class NeuSizeOfExpression: NeuUnaryExpression {

    public NeuSizeOfExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

public static partial class NeuSizeOfExpressionFunctions {

    public static NeuTypeIdentifier? GetTypeIdentifier(
        this NeuSizeOfExpression sizeOfExpr) {

        return sizeOfExpr.GetFirstOrDefault<NeuTypeIdentifier>();
    }
}