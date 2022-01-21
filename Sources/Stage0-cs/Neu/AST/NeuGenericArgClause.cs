
namespace Neu;

public partial class NeuGenericArgClause: NeuNode {

    public NeuGenericArgClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
