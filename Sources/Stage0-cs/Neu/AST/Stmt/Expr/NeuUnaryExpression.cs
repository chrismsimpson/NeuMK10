
namespace Neu;

public partial class NeuUnaryExpression: NeuExpression {

    public NeuUnaryExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
