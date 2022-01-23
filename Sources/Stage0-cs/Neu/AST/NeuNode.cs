
namespace Neu;

public partial class NeuNode: Node {

    public NeuNode(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}