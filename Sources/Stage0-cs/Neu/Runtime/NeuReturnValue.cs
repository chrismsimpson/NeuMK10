
namespace Neu;

public partial class NeuReturnValue: NeuValue {

    public NeuValue? Value { get; init; }

    ///

    public NeuReturnValue(
        NeuValue? value) {

        this.Value = value;
    }
}

///

public static partial class NeuReturnValueFunctions {
    
    public static bool Matches(
        this NeuReturnValue returnValue,
        NeuNode? returnType) {

        switch (returnValue.Value) {

            case NeuInteger i when 
                returnType is NeuSimpleTypeId simpleTypeId && 
                simpleTypeId.GetFirstOrDefault<NeuIdentifier>() is NeuIdentifier id && 
                id.Source == "Int":
                return true;

            ///
                
            default:
                return false;
        }
    }
}