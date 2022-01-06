
namespace Neu;

public partial class NeuValue {

    public NeuValue() { } 
}

///

public partial class NeuValue {

    public static readonly NeuValue Void = new NeuVoid();
    // public static readonly NeuValue Null = new NeuNull();
}

public partial class NeuReturnValue: NeuValue {

    public NeuValue? Value { get; init; }

    ///

    public NeuReturnValue(
        NeuValue? value) {

        this.Value = value;
    }
}

///

public static partial class NeuValueFunctions {

    public static String Dump(
        this NeuValue value) {

        switch (value) {
            
            case NeuVoid _:
                return "void";

            ///

            case NeuInteger i:
                return $"int: {i.Value}";

            ///

            default:
                return $"Unknown: {value}";
        }   
    }
}
