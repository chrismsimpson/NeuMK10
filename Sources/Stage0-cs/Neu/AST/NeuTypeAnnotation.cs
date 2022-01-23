
namespace Neu;

public partial class NeuTypeAnnotation: NeuNode {

    public NeuTypeAnnotation(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuTypeAnnotationFunctions {

    public static NeuTypeIdentifier? GetTypeIdentifier(
        this NeuTypeAnnotation typeAnnotation) {

        return typeAnnotation.GetFirstOrDefault<NeuTypeIdentifier>();
    }
}