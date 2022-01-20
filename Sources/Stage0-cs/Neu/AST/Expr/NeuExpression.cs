
namespace Neu;

public partial class NeuExpression: NeuStatement { // NeuCodeBlockItem {

    public NeuExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
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