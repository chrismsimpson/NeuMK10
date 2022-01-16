
namespace Neu;

public partial class NeuPatternBinding: NeuNode {

    public NeuPatternBinding(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}
    
public partial class NeuPatternBindingList: NeuNode {

    public NeuPatternBindingList(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuPatternBindingFunctions {

    public static bool EndsWithNewline(
        this NeuPatternBinding patternBinding) {

        var s = patternBinding.Children.FirstOrDefault()?.Start;

        if (s == null) {

            throw new Exception();
        }

        ///

        var e = patternBinding.Children.LastOrDefault()?.End;

        if (e == null) {

            throw new Exception();
        }

        ///

        return e.LineNumber > s.LineNumber;
    }
}