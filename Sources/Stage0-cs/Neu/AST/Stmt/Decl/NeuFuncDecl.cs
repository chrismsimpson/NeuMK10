
namespace Neu;

public partial class NeuFuncDecl: NeuDeclaration {

    public NeuFuncDecl(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuFuncDecl(
        String name)
        : base(
            new Node[] {
                new NeuKeyword("func", new UnknownLocation(), new UnknownLocation(), NeuKeywordType.Func),
                new NeuIdentifier(name, new UnknownLocation(), new UnknownLocation()),
                new NeuFuncSignature(
                    new NeuParamClause(),
                    new NeuReturnClause(
                        new NeuSimpleTypeId(
                            new NeuIdentifier("Bool")))),
                new NeuCodeBlock(
                    new NeuCodeBlockItemList(
                        new NeuCodeBlockItem[] {
                            new NeuReturnStatement(
                                new NeuBoolLiteralExpression(
                                    new NeuKeyword("true", new UnknownLocation(), new UnknownLocation(), NeuKeywordType.True)))
                        }))
            }, 
            new UnknownLocation(), 
            new UnknownLocation()) { }
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