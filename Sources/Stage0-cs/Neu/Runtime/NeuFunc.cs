
namespace Neu;

public partial class NeuFunc: NeuOperation {

    public NeuFunc(
        String name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode node)
        : base(name, moduleName, namespaceName, typeName, node) {

    }
}

///

public static partial class NeuFuncFunctions {

    public static NeuCodeBlock? GetBodyCodeBlock(
        this NeuOperation func) {

        return func.Node.GetFirstOrDefault<NeuCodeBlock>();
    }

    public static NeuFuncSignature? GetFuncSignature(
        this NeuOperation func) {

        return func.Node.GetFirstOrDefault<NeuFuncSignature>();
    }

    public static NeuParamClause? GetParamClause(
        this NeuOperation func) {
        
        return func
            .GetFuncSignature()?
            .GetParamClause();
    }

    public static NeuReturnClause? GetReturnClause(
        this NeuOperation func) {

        return func
            .GetFuncSignature()?
            .GetReturnClause();
    }

    public static NeuNode? GetReturnType(
        this NeuOperation func) {

        return func
            .GetReturnClause()?
            .GetFirstOrDefault<NeuNode>();
    }
}
