
namespace Neu;

public partial class NeuPattern: NeuNode {

    public NeuPattern(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}