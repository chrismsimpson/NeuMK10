
namespace Neu;

public partial class NeuNumber: NeuValue {

    public NeuNumber()
        : base() { }
}

///

public partial class NeuFloat: NeuValue {

    public float Value { get; init; }

    ///

    public NeuFloat(
        float value)
        : base() {

        this.Value = value;   
    }
}

///

public partial class NeuInteger: NeuValue {

    public int Value { get; init; }

    ///

    public NeuInteger(
        int value)
        : base() {
            
        this.Value = value;
    }
}
