
namespace Neu;

public partial class NeuFunc: NeuValue {

    public String Name { get; init; }

    public NeuNode Node { get; init; }

    ///

    public NeuFunc(
        String name,
        NeuNode node)
        : base() {

        this.Name = name;
        this.Node = node;
    }
}

///

public static partial class NeuFuncFunctions {

    public static NeuCodeBlock? GetBodyCodeBlock(
        this NeuFunc func) {

        return func.Node.GetFirstOrDefault<NeuCodeBlock>();
    }

    public static NeuFuncSignature? GetFuncSignature(
        this NeuFunc func) {

        return func.Node.GetFirstOrDefault<NeuFuncSignature>();
    }

    public static NeuNode? GetReturnType(
        this NeuFunc func) {

        var funcSignature = func.GetFuncSignature();

        if (funcSignature == null) {

            throw new Exception();
        }

        ///

        return funcSignature?
            .GetReturnClause()?
            .GetFirstOrDefault<NeuNode>();
    }
}
