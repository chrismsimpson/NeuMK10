
namespace Neu;

public partial class NeuPostfixExpression: NeuUnaryExpression {

    public NeuPostfixExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

public static partial class NeuPostfixExpressionFunctions {

    public static Node? GetOperand(
        this NeuPostfixExpression postfixExpression) {

        var done = false;

        ///

        for (var i = 0; i < postfixExpression.Children.Count() && !done; i++) {

            var child = postfixExpression.Children.ElementAt(i);

            ///

            switch (child) {

                case NeuPostfixOperator op:

                    done = true;

                    break;

                ///

                case NeuExpression _:
                case NeuIdentifier _: // maybe can remove this?
                case NeuLiteral _:  // maybe can remove this?
                
                    return child;

                ///
                
                case NeuPunc p: // change to default?

                    continue;
            }
        }

        ///

        return null;
    }

    ///

    public static NeuPostfixOperator? GetOperator(
        this NeuPostfixExpression postfixExpression) {

        for (var i = postfixExpression.Children.Count(); i > 0; --i) {

            var child = postfixExpression.Children.ElementAt(i - 1);

            ///

            switch (child) {

                case NeuPostfixOperator op:

                    return op;

                ///

                default:

                    continue;
            }
        }

        ///

        return null;
    }
}