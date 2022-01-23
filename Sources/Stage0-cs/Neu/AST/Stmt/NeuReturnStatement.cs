
namespace Neu;

public partial class NeuReturnStatement: NeuStatement {

    public NeuReturnStatement(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuReturnStatementFunctions {

    public static Node? GetArgument(
        this NeuReturnStatement retStmt) {

        foreach (var child in retStmt.Children) {

            switch (child) {

                case NeuExpression expr:

                    return expr;

                ///

                case NeuLiteral lit:

                    return lit;

                ///

                case NeuIdentifier id:

                    return id;

                ///

                default:

                    break;
            }   
        }

        ///

        return null;
    }
}