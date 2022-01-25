
namespace IR;

public partial class IROperation: IOperation {

    public String? Name { get; init; }

    public String? ModuleName { get; init; }

    public String? NamespaceName { get; init; }

    public String? TypeName { get; init; }

    public Node? Node { get; init; }

    public bool Writable { get; init; }

    public bool Executable { get; init; }

    ///

    public IROperation(
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        IRNode? node,
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