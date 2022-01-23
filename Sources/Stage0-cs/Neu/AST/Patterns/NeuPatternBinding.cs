
namespace Neu;

public partial class NeuPatternBinding: NeuNode {

    public NeuPatternBinding(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}
    
public partial class NeuPatternBindingList: NeuNode {

    public NeuPatternBindingList(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
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

    ///

    public static NeuPattern? GetPattern(
        this NeuPatternBinding patternBinding) {

        return patternBinding.GetFirstOrDefault<NeuPattern>();
    }

    ///

    public static NeuNode? GetBinding(
        this NeuPatternBinding patternBinding) {

        var patternReached = false;

        ///

        foreach (var c in patternBinding.Children) {

            switch (c) {

                case NeuPattern _ when !patternReached: // only toggle on a single pattern

                    patternReached = true;

                    break;

                ///

                case NeuTypeAnnotation _:

                    break;

                ///

                case NeuNode n when patternReached:

                    return n;

                ///

                default:

                    break;
            }
        }

        ///

        return null;
    }
}