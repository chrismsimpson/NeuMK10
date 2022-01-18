
namespace Neu;

public partial class NeuNumberPrimitive: NeuValue {

    public NeuNumberPrimitive()
        : base() { }
}

///

public partial class NeuInteger: NeuNumberPrimitive {

    public int Value { get; init; }

    ///

    public NeuInteger(
        int value)
        : base() {
            
        this.Value = value;
    }
}

///

public partial class NeuFloat: NeuNumberPrimitive {

    public float Value { get; init; }

    ///

    public NeuFloat(
        float value)
        : base() {

        this.Value = value;   
    }
}

///

public partial class NeuDouble: NeuNumberPrimitive {

    public double Value { get; init; }

    ///

    public NeuDouble(
        float value)
        : base() {

        this.Value = value;   
    }
}
