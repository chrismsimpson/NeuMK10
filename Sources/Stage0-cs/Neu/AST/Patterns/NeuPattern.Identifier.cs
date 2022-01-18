
namespace Neu;

public partial class NeuIdentifierPattern: NeuPattern {

    public NeuIdentifierPattern(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuIdentifierPatternFunctions {

    public static NeuIdentifier? GetIdentifier(
        this NeuIdentifierPattern idPattern) {

        return idPattern.GetFirstOrDefault<NeuIdentifier>();
    }
}