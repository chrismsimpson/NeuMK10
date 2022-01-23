
namespace Neu;

public partial class NeuInfixExpression: NeuExpression {

    public NeuInfixExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuInfixExpressionFunctions {

    public static Node GetLHSNode(
        this NeuInfixExpression infixExpression) {

        var done = false;

        ///

        for (var i = 0; i < infixExpression.Children.Count() && !done; i++) {

            var child = infixExpression.Children.ElementAt(i);

            ///

            switch (child) {

                case NeuInfixOperator op:

                    done = true;

                    break;

                ///

                case NeuExpression _:
                case NeuIdentifier _: // maybe can remove this?
                case NeuLiteral _:  // maybe can remove this?
                
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
        this NeuInfixExpression infixExpression) {

        var done = false;

        ///

        for (var i = infixExpression.Children.Count(); i > 0 && !done; --i) {

            var child = infixExpression.Children.ElementAt(i - 1);

            ///

            switch (child) {

                case NeuInfixOperator op:

                    done = true;

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

    public static NeuInfixOperator GetOperator(
        this NeuInfixExpression infixExpression) {

        foreach (var child in infixExpression.Children) {

            switch (child) {
                
                case NeuInfixOperator o:

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