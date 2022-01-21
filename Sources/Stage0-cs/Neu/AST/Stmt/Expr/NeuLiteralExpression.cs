
namespace Neu;

public partial class NeuLiteralExpression: NeuExpression {

    public NeuLiteralExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
