
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuVarDecl varDecl) {

        var kind = varDecl.GetDeclarationKindKeyword();

        ///

        switch (kind) {

            case NeuKeyword k 
                when 
                    k.KeywordType == NeuKeywordType.Let && 
                    interpreter.Stack.Count() == 0:

                    /// Add a global

                    throw new Exception();

            ///

            case NeuKeyword k 
                when 
                    k.KeywordType == NeuKeywordType.Var && 
                    interpreter.Stack.Count() == 0:

                    /// Add a local

                    throw new Exception();

            ///

            case NeuKeyword k 
                when 
                    k.KeywordType == NeuKeywordType.Let:

                    /// Add let on the stack

                    throw new Exception();

            ///

            case NeuKeyword k 
                when 
                    k.KeywordType == NeuKeywordType.Var:

                    /// Add var on the stack

                    throw new Exception();

            ///

            default:

                throw new Exception();
        }

        ///

        throw new Exception();
    }

    // public static NeuValue Execute() {

    // }
}
