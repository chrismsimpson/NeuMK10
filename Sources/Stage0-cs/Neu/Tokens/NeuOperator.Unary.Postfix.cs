
namespace Neu;

public partial class NeuPostfixOperator: NeuUnaryOperator {

    public NeuPostfixOperator(
        String source,
        SourceLocation start,
        SourceLocation end,
        NeuUnaryOperatorType operatorType)
        : base(source, start, end, operatorType) { }
}

///

public static partial class NeuPostfixOperatorFunctions {

    public static int GetPrecedence(
        this NeuPostfixOperator prefixOp) {

        throw new Exception();
    }
}