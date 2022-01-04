
namespace Neu;

public partial class NeuFuncSignature: NeuNode {

    public NeuFuncSignature(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
