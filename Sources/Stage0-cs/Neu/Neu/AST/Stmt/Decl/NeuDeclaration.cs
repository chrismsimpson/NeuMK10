
namespace Neu;

public partial class NeuDeclaration: NeuStatement {

    public NeuDeclaration(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
