
namespace Neu;

public partial class NeuOperation: IOperation {

    public String? Name { get; init; }

    public String? ModuleName { get; init; }

    public String? NamespaceName { get; init; }

    public String? TypeName { get; init; }

    public Node? Node { get; init; }

    public bool Writable { get; init; }

    public bool Executable { get; init; }

    ///

    public NeuOperation(
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode? node,
        bool writable,
        bool executable)
        : base() {

        this.Name = name;
        this.ModuleName = moduleName;
        this.NamespaceName = namespaceName;
        this.TypeName = typeName;
        this.Node = node;
        this.Writable = writable;
        this.Executable = executable;
    }
}

///

public static partial class NeuOperationFunctions {

    public static String Dump(
        this NeuOperation operation) {

        switch (operation) {

            case NeuReturnResult returnResult:

                return returnResult.Dump();

            ///

            case NeuValue value:

                return value.Dump();

            ///

            case NeuVoid _:

                return "void";

            ///

            case var op:

                return $"{op} (unknown)";
        }
    }
}

///

public static partial class NeuOperationFunctions {

    public static NeuCodeBlock? GetBodyCodeBlock(
        this NeuOperation op) {

        return op.Node?.GetFirstOrDefault<NeuCodeBlock>();
    }

    public static NeuFuncSignature? GetFuncSignature(
        this NeuOperation op) {

        return op.Node?.GetFirstOrDefault<NeuFuncSignature>();
    }

    public static NeuParamClause? GetParamClause(
        this NeuOperation op) {
        
        return op
            .GetFuncSignature()?
            .GetParamClause();
    }

    public static NeuReturnClause? GetReturnClause(
        this NeuOperation op) {

        return op
            .GetFuncSignature()?
            .GetReturnClause();
    }

    public static NeuNode? GetReturnType(
        this NeuOperation op) {

        return op
            .GetReturnClause()?
            .GetFirstOrDefault<NeuNode>();
    }
}
