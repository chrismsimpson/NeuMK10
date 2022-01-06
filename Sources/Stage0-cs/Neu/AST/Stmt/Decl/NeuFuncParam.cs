
namespace Neu;

public partial class NeuFuncParam: NeuNode {

    public NeuFuncParam(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

public partial class NeuFuncParamList: NeuNode {

    public NeuFuncParamList(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
