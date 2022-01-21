
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuSource source,
        IEnumerable<IArgument> arguments) {

        var codeBlockItemList = source.GetCodeBlockItemList();

        if (codeBlockItemList == null) {

            throw new Exception();
        }
        
        ///

        if (codeBlockItemList.Children.Count() == 0) {

            return NeuOperation.Void;
        }

        ///

        var hasMainFunction = false;

        ///

        var stackOperations = new List<Node>();

        ///

        foreach (var item in codeBlockItemList.Children) {

            switch (item) {

                case NeuDeclaration decl:

                    var result = interpreter.Execute(decl);

                    if (result == null) {

                        throw new Exception();
                    }

                    ///

                    if (result is NeuFunc func && func.Name == "main") {

                        hasMainFunction = true;
                    }

                    ///

                    break;

                ///

                case Node n:

                    stackOperations.Add(n);

                    break;

                ///

                case var i:

                    throw new Exception($"Unexpected: {i}");

            }
        }

        ///

        var lastValue = NeuOperation.Void;

        ///

        foreach (var stackOp in stackOperations) {
            
            lastValue = interpreter.Execute(stackOp);

            ///

            interpreter.SourceOutput.Add(lastValue);
        }

        ///

        if (hasMainFunction) {

            var mainCandidates = interpreter.GetOperations("main", null, null, null);

            if (mainCandidates.Count() != 1) {

                throw new Exception();
            }

            ///

            var mainFunc = mainCandidates.FirstOrDefault() as NeuFunc;

            if (mainFunc == null) {

                throw new Exception();
            }

            ///

            lastValue = interpreter.Execute(mainFunc, Empty<NeuArgument>());

            ///

            interpreter.SourceOutput.Add(lastValue);
        }

        ///

        return lastValue;
    }
}