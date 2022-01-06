
namespace Neu;

public partial class NeuFuncSignature: NeuNode {

    public NeuFuncSignature(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

public static partial class NeuFuncSignatureFunctions {
    
    public static NeuReturnClause? GetReturnClause(
        this NeuFuncSignature funcSignature) {

        return funcSignature.GetFirstOrDefault<NeuReturnClause>();
    }
}
