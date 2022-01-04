
namespace Neu;

public partial class NeuReturnStatement: NeuStatement {

    public NeuReturnStatement(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
