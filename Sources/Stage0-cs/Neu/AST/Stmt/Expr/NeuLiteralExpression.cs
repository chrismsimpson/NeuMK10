
namespace Neu;

public partial class NeuLiteralExpression: NeuExpression {

    public NeuLiteralExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
