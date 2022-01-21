
namespace Neu;

public partial class NeuArrayElementList: NeuNode {

    public NeuArrayElementList(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
