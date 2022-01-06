
namespace Neu;

public partial class NeuSimpleTypeId : NeuNode {

    public NeuSimpleTypeId(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
