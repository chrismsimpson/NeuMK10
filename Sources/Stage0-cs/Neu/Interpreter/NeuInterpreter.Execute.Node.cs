
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue? Execute(
        this NeuInterpreter interpreter,
        Node node) {

        switch (node) {

            case NeuDeclaration decl:
                return interpreter.Execute(decl);

            ///

            case NeuStatement stmt:
                return interpreter.Execute(stmt);

            ///
        
            case NeuExpression e:
                return interpreter.Execute(e);

            ///

            case NeuIdentifier i:
                return interpreter.Execute(i);

            ///

            case NeuLiteral l:
                return interpreter.Execute(l);

            ///

            // case NeuVariableDeclarator d:
            //     return interpreter.Execute(d);

            ///
            
            case NeuPunc punc:
                return null;

            ///

            case NeuNode neuNode:
                return interpreter.Run(neuNode);

            ///

            default:
                
                WriteLine("NO OP\n");

                return NeuValue.Void;
        }
    }
}
