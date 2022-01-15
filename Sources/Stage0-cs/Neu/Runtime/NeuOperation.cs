
namespace Neu;

public partial class NeuOperation: NeuValue, IOperation {

    public String? Name { get; init; }

    public String? ModuleName { get; init; }

    public String? NamespaceName { get; init; }

    public String? TypeName { get; init; }

    public Node Node { get; init; }

    ///

    public NeuOperation(
        String? name,
        String? moduleName,
        String? namespaceName,
        String? typeName,
        NeuNode node)
        : base() {

        this.Name = name;
        this.ModuleName = moduleName;
        this.NamespaceName = namespaceName;
        this.TypeName = typeName;
        this.Node = node;
    }
}
