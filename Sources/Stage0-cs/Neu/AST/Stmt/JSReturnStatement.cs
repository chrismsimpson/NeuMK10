
namespace Neu;

public partial class NeuReturnStatement: NeuStatement {

    public NeuReturnStatement(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuReturnStatementFunctions {

    public static Node? GetArgument(
        this NeuReturnStatement retStmt) {

        foreach (var child in retStmt.Children) {

            switch (child) {

                case NeuExpression e:
                    return e;

                ///

                case NeuLiteral l:
                    return l;

                ///

                default:
                    continue;
            }   
        }

        ///

        return null;
    }
}