
namespace Neu;

public partial class NeuHoistedFrame: NeuFrame {

    public NeuHoist Hoist { get; init; }

    public NeuOperation Operation { get; set; }

    ///

    public NeuHoistedFrame(
        NeuHoist hoist,
        NeuOperation operation)
        : base(null) {
            
        this.Hoist = hoist;
        this.Operation = operation;
    }
}