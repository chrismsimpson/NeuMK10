
namespace Neu;

public partial class NeuExpressionStatement: NeuStatement {

    public NeuExpressionStatement(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuExpressionStatementFunctions {

    public static NeuExpression? GetExpression(
        this NeuExpressionStatement expressionStatement) {

        return expressionStatement.GetFirstOrDefault<NeuExpression>();
    }
}