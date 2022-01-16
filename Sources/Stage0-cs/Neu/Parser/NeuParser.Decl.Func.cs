
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuFuncDecl ParseFuncDecl(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var funcKeyword = parser.Tokenizer.MaybeNextFunc();

        if (funcKeyword == null) {

            throw new Exception();
        }

        children.Add(funcKeyword);

        ///

        var identifier = parser.Tokenizer.MaybeNextIdentifier();

        if (identifier == null) {

            throw new Exception();
        }

        children.Add(identifier);

        ///

        var signature = parser.ParseFuncSignature();

        children.Add(signature);

        ///

        var codeBlock = parser.ParseCodeBlock();

        children.Add(codeBlock);

        ///

        return new NeuFuncDecl(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    ///

    public static NeuFuncSignature ParseFuncSignature(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var paramClause = parser.ParseParamClause();

        children.Add(paramClause);

        ///

        if (parser.Tokenizer.MatchArrow()) {

            var returnClause = parser.ParseReturnClause();

            children.Add(returnClause);
        }

        ///

        return new NeuFuncSignature(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    ///

    public static NeuParamClause ParseParamClause(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var leftParen = parser.Tokenizer.MaybeNextLeftParen();

        if (leftParen == null) {

            throw new Exception();
        }

        children.Add(leftParen);

        ///

        var paramList = parser.ParseFuncParamList();

        children.Add(paramList);

        ///

        var rightParen = parser.Tokenizer.MaybeNextRightParen();

        if (rightParen == null) {

            throw new Exception();
        }

        children.Add(rightParen);

        ///

        return new NeuParamClause(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static NeuFuncParamList ParseFuncParamList(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var parameters = parser.ParseFuncParams();

        ///

        return new NeuFuncParamList(
            children: parameters,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }

    public static IEnumerable<NeuFuncParam> ParseFuncParams(
        this NeuParser parser) {

        var parameters = new List<NeuFuncParam>();

        ///

        while (!parser.Tokenizer.IsEof()) {

            if (parser.Tokenizer.MatchRightParen()) {

                break;
            }

            ///

            var param = parser.ParseFuncParam();

            parameters.Add(param);
        }

        ///

        return parameters;
    }

    public static NeuFuncParam ParseFuncParam(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var name = parser.Tokenizer.MaybeNextIdentifier();

        if (name == null) {

            throw new Exception();
        }

        children.Add(name);

        ///

        var colon = parser.Tokenizer.MaybeNextColon();

        if (colon == null) {

            throw new Exception();
        }

        children.Add(colon);

        ///

        // var paramType = parser.ParseType();
        var paramType = parser.ParseTypeIdentifier();

        children.Add(paramType);

        ///

        if (parser.Tokenizer.MatchComma()) {

            var comma = parser.Tokenizer.MaybeNextComma();

            if (comma == null) {

                throw new Exception();
            }

            children.Add(comma);
        }

        ///

        return new NeuFuncParam(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());    
    }

    public static NeuReturnClause ParseReturnClause(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        var children = new List<Node>();

        ///

        var arrow = parser.Tokenizer.MaybeNextArrow();

        if (arrow == null) {

            throw new Exception();
        }

        children.Add(arrow);

        ///

        // var retType = parser.ParseType();
        var retType = parser.ParseTypeIdentifier();

        children.Add(retType);

        ///

        return new NeuReturnClause(
            children: children,
            start: start,
            end: parser.Tokenizer.GetLocation());
    }
}
