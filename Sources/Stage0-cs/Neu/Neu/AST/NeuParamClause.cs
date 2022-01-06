
namespace Neu;

public partial class NeuParamClause: Node {

    public NeuParamClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
