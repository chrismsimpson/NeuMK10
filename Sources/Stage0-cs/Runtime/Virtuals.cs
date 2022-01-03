
namespace Neu;

public partial class VirtualOperation {

    public String? Name { get; init; }

    public Node Node { get; init; }

    public VirtualOperation(
        String? name,
        Node node) {

        this.Name = name;
        this.Node = node;
    }
}

public partial class VirtualFunction: VirtualOperation {

    public VirtualFunction(
        String? name,
        Node node)
        : base(name, node) { }
}