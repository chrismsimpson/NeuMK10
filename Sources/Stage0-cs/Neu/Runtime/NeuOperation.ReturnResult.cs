
namespace Neu;

public partial class NeuReturnResult: NeuOperation {

    public NeuOperation? Result { get; init; }

    ///

    public NeuReturnResult(
        NeuOperation? result)
        : base(null, null, null, null, null, false, false) {
            
        this.Result = result;
    }
}

///

public static partial class NeuReturnResultFunctions {

    public static String Dump(
        this NeuReturnResult returnResult) {

        switch (returnResult.Result) {

            case NeuOperation result:

                return $"{result.Dump()} (return result)";

            ///

            case null:

                return $"null (return result)";
        }
    }
    
    public static bool Matches(
        this NeuReturnResult returnResult,
        NeuNode? returnType) {

        switch (returnResult.Result) {

            case NeuInteger i when 
                returnType is NeuSimpleTypeId simpleTypeId && 
                simpleTypeId.GetFirstOrDefault<NeuIdentifier>() is NeuIdentifier id && 
                id.Source == "Int":
                
                return true;

            ///

            case NeuFloat f when 
                returnType is NeuSimpleTypeId simpleTypeId && 
                simpleTypeId.GetFirstOrDefault<NeuIdentifier>() is NeuIdentifier id &&
                id.Source == "Float":

                return true;

            ///

            case NeuBool b when 
                returnType is NeuSimpleTypeId simpleTypeId &&
                simpleTypeId.GetFirstOrDefault<NeuIdentifier>() is NeuIdentifier id &&
                id.Source == "Bool":

                return true;

            ///

            case NeuVoid when returnType == null:

                return true;

            ///
                
            default:
                return false;
        }
    }
}