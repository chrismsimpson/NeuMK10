
namespace Neu;

public partial class NeuExpression : NeuCodeBlockItem {

    public NeuExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
