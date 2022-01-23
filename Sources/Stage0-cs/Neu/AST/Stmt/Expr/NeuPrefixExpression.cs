
namespace Neu;

public partial class NeuPrefixExpression: NeuUnaryExpression {

    public NeuPrefixExpression(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuPrefixExpressionFunctions {

    public static NeuPrefixOperator? GetOperator(
        this NeuPrefixExpression prefixExpression) {

        return prefixExpression.GetFirstOrDefault<NeuPrefixOperator>();
    }

    ///

    public static Node? GetOperand(
        this NeuPrefixExpression prefixExpression) {

        var done = false;

        ///

        for (var i = prefixExpression.Children.Count(); i > 0 && !done; --i) {

            var child = prefixExpression.Children.ElementAt(i - 1);

            ///

            switch (child) {

                case NeuPrefixOperator op:

                    done = true;

                    break;

                ///

                case NeuExpression _:
                case NeuIdentifier _: // maybe can remove this?
                case NeuLiteral _:  // maybe can remove this?
                
                    return child;

                ///

                default:

                    continue;
            }
        }

        ///

        return null;
    }
}