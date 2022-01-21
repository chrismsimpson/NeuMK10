
namespace Neu;

public partial class NeuGenericArgList: NeuNode {

    public NeuGenericArgList(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
