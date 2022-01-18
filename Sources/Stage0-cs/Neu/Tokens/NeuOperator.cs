
namespace Neu;

public partial class NeuOperator: NeuToken {

    public NeuOperator(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

public static partial class NeuOperatorFunctions {

    public static int GetPrecedence(
        this NeuOperator op) {

        switch (op) {
            
            case NeuPrefixOperator prefix:

                return prefix.GetPrecedence();

            ///

            case NeuInfixOperator infix:

                return infix.GetPrecedence();

            ///

            case NeuPostfixOperator postfix:

                return postfix.GetPrecedence();

            ///

            default:

                throw new Exception();
        }
    }
}