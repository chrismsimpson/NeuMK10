
namespace Neu;

public partial class NeuInteger: NeuValuePrimitive {

    public int Value { get; init; }

    ///

    public NeuInteger(
        int value)
        : base() {
            
        this.Value = value;
    }
}

///

public partial class NeuFloat: NeuValuePrimitive {

    public float Value { get; init; }

    ///

    public NeuFloat(
        float value)
        : base() {

        this.Value = value;   
    }
}

///

public partial class NeuDouble: NeuValuePrimitive {

    public double Value { get; init; }

    ///

    public NeuDouble(
        float value)
        : base() {

        this.Value = value;   
    }
}
