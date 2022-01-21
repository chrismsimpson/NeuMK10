
namespace Neu;

public partial class NeuArrayElement: NeuNode {

    public NeuArrayElement(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuArrayElementFunctions {

    public static NeuExpression? GetExpression(
        this NeuArrayElement arrayElement) {

        return arrayElement.GetFirstOrDefault<NeuExpression>();
    }
}