
namespace Neu;

public partial class NeuFuncDecl: NeuDeclaration {

    public NeuFuncDecl(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuFuncDeclFunctions {

    public static String? GetName(
        this NeuFuncDecl funcDecl) {

        foreach (var child in funcDecl.Children) {

            switch (child) {

                case NeuIdentifier id:

                    return id.Source;

                ///

                case NeuPunc _:

                    return null;

                ///

                default:

                    break;
            }
        }

        ///

        return null;
    }
}