
namespace Neu;

public partial class NeuSimpleTypeId: NeuTypeIdentifier {

    public NeuSimpleTypeId(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuSimpleTypeId(
        NeuIdentifier id)
        : base(new Node[] { id }, new UnknownLocation(), new UnknownLocation()) { }
}

public static partial class NeuSimpleTypeIdFunctions {

    public static NeuIdentifier? GetIdentifer(
        this NeuSimpleTypeId simpleTypeId) {

        return simpleTypeId.GetFirstOrDefault<NeuIdentifier>();
    }
}