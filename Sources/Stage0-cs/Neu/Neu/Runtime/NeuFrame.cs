
namespace Neu;

public partial class NeuFrame: Frame {

    public NeuFrame(
        Node? node)
        : base (node) { }
}

///

// public partial class NeuNodeFrame: NeuFrame {

//     public NeuNode Node { get; init; }

//     ///

//     public NeuNodeFrame(
//         NeuNode node)
//         : base() {

//         this.Node = node;
//     }
// }

// ///

// public partial class NeuHoistedFrame: NeuFrame {

//     public NeuHoist Hoist { get; init; }

//     public NeuValue Value { get; set; }

//     ///

//     public NeuHoistedFrame(
//         NeuHoist hoist,
//         NeuValue value) {
            
//         this.Hoist = hoist;
//         this.Value = value;
//     }
// }
