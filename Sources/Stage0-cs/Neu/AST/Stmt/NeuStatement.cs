
namespace Neu;

public partial class NeuStatement: NeuCodeBlockItem {

    public NeuStatement(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
