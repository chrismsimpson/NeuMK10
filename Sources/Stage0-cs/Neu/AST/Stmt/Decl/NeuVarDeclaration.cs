
namespace Neu;

public partial class NeuVarDecl: NeuDeclaration {

    public NeuVarDecl(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuVarDeclFunctions {

    public static NeuKeyword? GetDeclarationKindKeyword(
        this NeuVarDecl varDecl) {

        foreach (var child in varDecl.Children) {

            switch (child) {

                case NeuKeyword k when k.KeywordType == NeuKeywordType.Let:

                    return k;

                ///

                case NeuKeyword k when k.KeywordType == NeuKeywordType.Var:

                    return k;

                ///

                default:

                    return null;
            }
        }

        ///

        return null;
    }
}