
namespace Neu;

public partial class NeuSource: NeuNode {

    public NeuSource(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuSourceFunctions {

    public static NeuCodeBlockItemList? GetCodeBlockItemList(
        this NeuSource source) {

        return source.GetFirstOrDefault<NeuCodeBlockItemList>();
    }
}