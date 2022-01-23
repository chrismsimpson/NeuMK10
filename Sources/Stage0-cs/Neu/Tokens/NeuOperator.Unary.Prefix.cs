
namespace Neu;

public partial class NeuPrefixOperator: NeuUnaryOperator {

    public NeuPrefixOperator(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        NeuUnaryOperatorType operatorType)
        : base(source, start, end, operatorType) { }
}

///

public static partial class NeuPrefixOperatorFunctions {

    public static int GetPrecedence(
        this NeuPrefixOperator prefixOp) {

        throw new Exception();
    }
}