
namespace Neu;

public partial class NeuTypeIdentifier: NeuNode {

    public NeuTypeIdentifier(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
