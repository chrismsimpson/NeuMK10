
namespace Neu;

public partial class NeuBool: NeuValuePrimitive {

    public bool Value { get; init; }

    ///

    public NeuBool(
        bool value)
        : base() {
            
        this.Value = value;
    }
}
