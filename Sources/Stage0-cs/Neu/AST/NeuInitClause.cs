
namespace Neu;

public partial class NeuInitClause: NeuNode {

    public NeuInitClause(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuInitClauseFunctions {

    public static Node? GetInitializer(
        this NeuInitClause initClause) {

        var puncReached = false;

        ///

        foreach (var c in initClause.Children) {

            switch (c) {

                case NeuPunc _ when !puncReached: // only toggle on a single punc

                    puncReached = true;

                    break;

                ///

                case Node _ when puncReached:

                    return c;

                ///

                default:

                    continue;
            }
        }

        ///

        return null;
    }
}