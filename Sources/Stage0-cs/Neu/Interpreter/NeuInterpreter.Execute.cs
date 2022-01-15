
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        NeuNode node,
        params object[] arguments) {
            
        interpreter.Enter(node);

        ///

        NeuValue lastValue = NeuValue.Void;

        var done = false;

        for (var i = 0; i < node.Children.Count() && !done; i++) {

            var child = node.Children.ElementAt(i);

            ///

            if (child is NeuPunc) {

                continue;
            }

            ///

            var childResult = interpreter.Execute(child);

            ///

            switch (childResult) {

                case NeuReturnValue returnValue:

                    lastValue = returnValue;
                    // lastValue = returnValue.Value ?? NeuValue.Void;

                    done = true;

                    break;

                ///

                case NeuValue value:

                    lastValue = value;

                    break;

                ///

                default:

                    break;
            }
        }

        ///

        interpreter.Exit(node);

        ///

        // if (interpreter.Stack.Count == 0 && 
        //     lastValue is NeuFunc func &&
        //     func.Name == "main") {

        //     var returnType = func.GetReturnType();

        //     ///

        //     var body = func.GetBodyCodeBlock();

        //     if (body == null) {

        //         throw new Exception();
        //     }

        //     ///

        //     var funcResult = interpreter.Execute(body) as NeuReturnValue;

        //     if (funcResult == null) {

        //         throw new Exception();
        //     }

        //     ///

        //     if (!funcResult.Matches(returnType)) {

        //         throw new Exception("Value does not match return type");
        //     }

        //     ///

        //     lastValue = funcResult.Value ?? NeuValue.Void;
        // }

        ///

        return lastValue;
    }


    public static NeuValue Execute(
        this NeuInterpreter interpreter,
        Node node) {

        switch (node) {

            case NeuDeclaration decl:
                return interpreter.Execute(decl);

            ///

            case NeuStatement stmt:
                return interpreter.Execute(stmt);

            ///
        
            case NeuExpression expr:
                return interpreter.Execute(expr);

            ///

            // case NeuIdentifier i:
            //     return interpreter.Execute(i);

            ///

            case NeuLiteral l:
                return interpreter.Execute(l);

            ///

            // case NeuVariableDeclarator d:
            //     return interpreter.Execute(d);

            case NeuCodeBlockItemList list:

                return interpreter.Execute(list);

            ///
            
            // case NeuPunc punc:

            //     // Silent no-op
                
            //     return NeuValue.Void;

            ///

            case var n:
                
                WriteLine($"NeuInterpreter no op: {n.Dump()}");

                return NeuValue.Void;
        }
    }
}