
namespace Neu;

public partial class NeuReturnClause: NeuNode {
    
    public NeuReturnClause(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuReturnClause(
        NeuTypeIdentifier typeId)
        : base(
            new Node[] {
                new NeuPunc("->", new UnknownLocation(), new UnknownLocation(), NeuPuncType.Arrow),
                typeId
            },
            new UnknownLocation(), 
            new UnknownLocation()) { }
}

///

public static partial class NeuReturnClauseFunctions {

    public static NeuTypeIdentifier? GetTypeIdentifier(
        this NeuReturnClause returnClause) {

        return returnClause.GetFirstOrDefault<NeuTypeIdentifier>();
    }
}