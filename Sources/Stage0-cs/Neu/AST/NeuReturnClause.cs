
namespace Neu;

public partial class NeuReturnClause: NeuNode {
    
    public NeuReturnClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuReturnClauseFunctions {

    public static NeuTypeIdentifier? GetTypeIdentifier(
        this NeuReturnClause returnClause) {

        return returnClause.GetFirstOrDefault<NeuTypeIdentifier>();
    }
}