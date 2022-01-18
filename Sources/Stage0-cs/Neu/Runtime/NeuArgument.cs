
namespace Neu;

public partial class NeuArgument {

    public String? Name { get; init; }

    public NeuOperation? Value { get; init; }

    ///

    public NeuArgument(
        String? name,
        NeuOperation? value) {
            
        this.Name = name;
        this.Value = value;
    }
}
