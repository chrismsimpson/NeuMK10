
namespace Neu;

public partial class NeuFuncSignature: NeuNode {

    public NeuFuncSignature(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

public static partial class NeuFuncSignatureFunctions {
    
    public static NeuParamClause? GetParamClause(
        this NeuFuncSignature funcSignature) {

        return funcSignature.GetFirstOrDefault<NeuParamClause>();
    }

    public static NeuReturnClause? GetReturnClause(
        this NeuFuncSignature funcSignature) {

        return funcSignature.GetFirstOrDefault<NeuReturnClause>();
    }

    public static NeuTypeIdentifier? GetReturnClauseTypeIdentifier(
        this NeuFuncSignature funcSignature) {

        return funcSignature
            .GetReturnClause()?
            .GetTypeIdentifier();
    }
}
