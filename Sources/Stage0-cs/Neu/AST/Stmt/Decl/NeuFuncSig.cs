
namespace Neu;

public partial class NeuFuncSignature: NeuNode {

    public NeuFuncSignature(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuFuncSignature(
        NeuParamClause paramClause,
        NeuReturnClause? returnClause = null)
        : base(
            returnClause != null
                ? new Node[] { paramClause, returnClause }
                : new Node[] { paramClause },
            new UnknownLocation(), 
            new UnknownLocation()) { }
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
