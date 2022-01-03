
namespace Neu;

public abstract class Frame {

    public Node? Node { get; init; }

    ///

    public Frame(
        Node? node)
        : base()
    {
        this.Node = node;
    }
}