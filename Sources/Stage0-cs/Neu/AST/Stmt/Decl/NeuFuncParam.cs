
namespace Neu;

public partial class NeuFuncParam: NeuNode {

    public NeuFuncParam(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

public partial class NeuFuncParamList: NeuNode {

    public NeuFuncParamList(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end)
        : base(children, start, end) { }
}

///

public static partial class NeuFuncParamListFunctions {

    public static int Count(
        this NeuFuncParamList list) {

        switch (list.Children.Count()) {

            case 0:
                return 0;

            ///

            default:
                throw new Exception();
        }
    }
}