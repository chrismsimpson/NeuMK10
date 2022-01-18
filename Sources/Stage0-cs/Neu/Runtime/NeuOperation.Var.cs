
namespace Neu;

public partial class NeuVar: NeuOperation {

    public NeuOperation Value { get; init; }

    public NeuVar(
        String? name,
        NeuOperation value)
        : base(name, null, null, null, null, false, false) {

        this.Value = value;
    }
}