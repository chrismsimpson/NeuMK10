
namespace Neu;

public partial class NeuNode: Node {

    public NeuNode(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}