
namespace Neu;

public partial class NeuStatement: NeuCodeBlockItem {

    public NeuStatement(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
