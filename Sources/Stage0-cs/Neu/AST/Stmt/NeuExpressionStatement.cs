
namespace Neu;

public partial class NeuExpressionStatement: NeuStatement {

    public NeuExpressionStatement(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuExpressionStatementFunctions {

    public static NeuExpression? GetExpression(
        this NeuExpressionStatement expressionStatement) {

        return expressionStatement.GetFirstOrDefault<NeuExpression>();
    }
}