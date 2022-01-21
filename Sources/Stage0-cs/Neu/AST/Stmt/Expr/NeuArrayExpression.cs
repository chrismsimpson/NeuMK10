
namespace Neu;

public partial class NeuArrayExpression: NeuExpression {

    public NeuArrayExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuArrayExpressionFunctions {

    public static NeuArrayElementList? GetArrayElementList(
        this NeuArrayExpression arrayExpr) {

        return arrayExpr.GetFirstOrDefault<NeuArrayElementList>();
    }
}