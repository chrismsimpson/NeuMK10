
namespace Neu;

public partial class NeuRefClassDecl: NeuDeclaration {

    public NeuRefClassDecl(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public partial class NeuClassDecl: NeuRefClassDecl {

    public NeuClassDecl(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
