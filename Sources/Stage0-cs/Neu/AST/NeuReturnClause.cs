
namespace Neu;

public partial class NeuReturnClause: NeuNode {
    
    public NeuReturnClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
