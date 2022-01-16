
namespace Neu;

public partial class NeuPattern: NeuNode {

    public NeuPattern(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}