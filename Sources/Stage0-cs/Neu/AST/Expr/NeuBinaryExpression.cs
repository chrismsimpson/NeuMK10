
namespace Neu;

public partial class NeuBinaryExpression: NeuInfixExpression {

    public NeuBinaryExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
