
namespace Neu;

public partial class NeuTypeIdentifier: NeuNode {

    public NeuTypeIdentifier(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
