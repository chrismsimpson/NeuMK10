
namespace Neu;

public partial class NeuBinaryExpression: NeuExpression {

    public NeuBinaryExpression(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuBinaryExpressionFunctions {

    public static Node GetLHSNode(
        this NeuBinaryExpression binaryExpression) {

        for (var i = 0; i < binaryExpression.Children.Count(); i++) {

            var child = binaryExpression.Children.ElementAt(i);

            ///

            switch (child) {

                case NeuBinaryOperator op:

                    break;

                ///

                case NeuExpression _:
                case NeuIdentifier _:
                case NeuLiteral _:
                
                    return child;

                ///
                
                case NeuPunc p:

                    continue;
            }
        }

        ///

        throw new Exception();
    }

    public static Node GetRHSNode(
        this NeuBinaryExpression binaryExpression) {

        for (var i = binaryExpression.Children.Count(); i > 0; --i) {

            var child = binaryExpression.Children.ElementAt(i - 1);

            ///

            switch (child) {

                case NeuBinaryOperator op:

                    break;

                ///

                case NeuExpression _:
                case NeuIdentifier _:
                case NeuLiteral _:

                    return child;

                ///

                case NeuPunc p:

                    continue;
            }
        }

        ///

        throw new Exception();
    }

    public static NeuBinaryOperator GetOperator(
        this NeuBinaryExpression binaryExpression) {

        foreach (var child in binaryExpression.Children) {

            switch (child) {
                
                case NeuBinaryOperator o:

                    return o;

                ///

                default:

                    continue;
            }
        }

        ///
        
        throw new Exception();
    }
}