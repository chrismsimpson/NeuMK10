
namespace Neu;

public partial class NeuPostfixOperator: NeuOperator {

    public NeuPostfixOperator(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

///

public static partial class NeuPostfixOperatorFunctions {

    public static int GetPrecedence(
        this NeuPostfixOperator prefixOp) {

        throw new Exception();
    }
}