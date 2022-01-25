
namespace Neu;

public partial class NeuBoolLiteralExpression: NeuLiteralExpression {

    public NeuBoolLiteralExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }

    ///

    public NeuBoolLiteralExpression(
        NeuKeyword keyword)
        : base(new Node[] { keyword }, new UnknownLocation(), new UnknownLocation()) { }
}

///

public static partial class NeuBoolLiteralExpressionFunctions {

    public static NeuKeyword? GetBoolKeyword(
        this NeuBoolLiteralExpression boolLitExpr) {

        foreach (var child in boolLitExpr.Children) {

            switch (child) {

                case NeuKeyword k 
                    when 
                        k.KeywordType == NeuKeywordType.True || 
                        k.KeywordType == NeuKeywordType.False:

                    return k;

                ///

                default:

                    break;
            }
        }

        ///

        return null;
    }
}