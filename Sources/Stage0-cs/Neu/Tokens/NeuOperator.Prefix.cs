
namespace Neu;

public partial class NeuPrefixOperator: NeuOperator {

    public NeuPrefixOperator(
        String source,
        SourceLocation start,
        SourceLocation end)
        : base(source, start, end) { }
}

///

public static partial class NeuPrefixOperatorFunctions {

    public static int GetPrecedence(
        this NeuPrefixOperator prefixOp) {

        throw new Exception();
    }
}