
namespace Neu;

public partial class NeuParamClause: NeuNode {

    public NeuParamClause(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuParamClauseFunctions {

    public static NeuFuncParamList? GetFuncParamList(
        this NeuParamClause paramClause) {

        return paramClause.GetFirstOrDefault<NeuFuncParamList>();
    }
}