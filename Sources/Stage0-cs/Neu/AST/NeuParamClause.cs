
namespace Neu;

public partial class NeuParamClause: NeuNode {

    public NeuParamClause(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuParamClause()
        : base(
            new Node[] {
                new NeuPunc('(', new UnknownLocation(), new UnknownLocation(), NeuPuncType.LeftParen),
                new NeuFuncParamList(),
                new NeuPunc(')', new UnknownLocation(), new UnknownLocation(), NeuPuncType.RightParen),
            }, 
            new UnknownLocation(), 
            new UnknownLocation()) { }
}

///

public static partial class NeuParamClauseFunctions {

    public static NeuFuncParamList? GetFuncParamList(
        this NeuParamClause paramClause) {

        return paramClause.GetFirstOrDefault<NeuFuncParamList>();
    }
}