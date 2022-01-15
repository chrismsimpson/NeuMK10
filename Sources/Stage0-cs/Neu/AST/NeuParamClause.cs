
namespace Neu;

public partial class NeuParamClause: Node {

    public NeuParamClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuParamClauseFunctions {

    public static NeuFuncParamList? GetFuncParamList(
        this NeuParamClause paramClause) {

        return paramClause.GetFirstOrDefault<NeuFuncParamList>();
    }
}