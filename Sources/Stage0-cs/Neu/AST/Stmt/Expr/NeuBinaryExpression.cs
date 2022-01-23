
namespace Neu;

public partial class NeuBinaryExpression: NeuInfixExpression {

    public NeuBinaryExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
