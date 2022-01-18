
namespace Neu;

public static partial class NeuInterpreterFunctions {

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        NeuVarDecl varDecl) {

        // TODO: Change this so it's non-function scoped stack

        var inGlobalScope = interpreter.Stack.Count() == 0;

        ///

        var lastValue = NeuOperation.Void;
                
        ///

        var kind = varDecl.GetDeclarationKindKeyword();

        if (kind == null) {

            throw new Exception();
        }

        ///

        var patternBindingList = varDecl.GetPatternBindingList();

        if (patternBindingList == null) {

            throw new Exception();
        }

        ///

        foreach (var c in patternBindingList.Children) {

            switch (c) {

                case NeuPatternBinding patternBinding:

                    lastValue = interpreter.Execute(inGlobalScope, kind, patternBinding);

                    break;

                ///

                default:

                    throw new Exception();
            }
        }

        ///

        return lastValue;
    }

    ///

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        bool inGlobalScope,
        NeuKeyword kindKeyword,
        NeuPatternBinding patternBinding) {

        var pattern = patternBinding.GetPattern();

        if (pattern == null) {

            throw new Exception();
        }

        ///

        var binding = patternBinding.GetBinding();

        if (binding == null) {

            throw new Exception();
        }

        ///

        switch (true) {

            case var _ 
                when 
                    pattern is NeuIdentifierPattern idPattern &&
                    binding is NeuInitClause initClause:

                return interpreter.Execute(inGlobalScope, kindKeyword, idPattern, initClause);

            ///

            default:

                throw new Exception();
        }
    }

    ///

    public static NeuOperation Execute(
        this NeuInterpreter interpreter,
        bool inGlobalScope,
        NeuKeyword kindKeyword,
        NeuIdentifierPattern idPattern,
        NeuInitClause initClause) {

        var id = idPattern.GetIdentifier();

        if (id == null) {

            throw new Exception();
        }

        ///

        var name = id.Source;

        if (IsNullOrWhiteSpace(name)) {

            throw new Exception();
        }

        ///

        var initializer = initClause.GetInitializer();

        if (initializer == null) {

            throw new Exception();
        }

        ///

        var initValue = interpreter.Execute(initializer);

        ///

        switch (true) {

            case var _
                when 
                    inGlobalScope &&
                    kindKeyword.KeywordType == NeuKeywordType.Let:

                    var globalScopedLet = interpreter.CreateVar(name, null, null, null, initValue);

                    if (globalScopedLet == null) {

                        throw new Exception();
                    }

                    return globalScopedLet;

            ///

            case var _
                when 
                    inGlobalScope &&
                    kindKeyword.KeywordType == NeuKeywordType.Var:

                    var globalScopedVar = interpreter.CreateVar(name, null, null, null, initValue);

                    if (globalScopedVar == null) {

                        throw new Exception();
                    }

                    return globalScopedVar;
            
            ///

            case var _
                when
                    kindKeyword.KeywordType == NeuKeywordType.Let:

                    var hoistedLet = interpreter.HoistVar(kindKeyword.KeywordType, name, initValue);

                    if (hoistedLet == null) {

                        throw new Exception();
                    }

                    return hoistedLet;

            ///

            case var _
                when
                    kindKeyword.KeywordType == NeuKeywordType.Var:

                    var hoistedVar = interpreter.HoistVar(kindKeyword.KeywordType, name, initValue);

                    if (hoistedVar == null) {

                        throw new Exception();
                    }

                    return hoistedVar;

            ///

            default:

                throw new Exception();
        }
    }
}
