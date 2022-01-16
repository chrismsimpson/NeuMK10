
namespace Neu;

public partial class NeuInitClause: NeuNode {

    public NeuInitClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
