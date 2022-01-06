
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

        if (func.Node is Node n) {

            foreach (var child in n.Children) {

                if (child is NeuCodeBlock b) {
                    
                    return b;
                }
            }
        }

        ///

        return null;
    }
}
