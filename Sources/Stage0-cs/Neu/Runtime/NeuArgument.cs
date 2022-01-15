
namespace Neu;

public partial class NeuArgument {

    public String? Name { get; init; }

    public NeuValue? Value { get; init; }

    ///

    public NeuArgument(
        String? name,
        NeuValue? value) {
            
        this.Name = name;
        this.Value = value;
    }
}
