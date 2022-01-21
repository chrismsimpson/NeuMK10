
namespace Neu;

public static partial class NeuParserFunctions {

    public static NeuStatement ParseStatementAfterDroppingComments(
        this NeuParser parser) {

        parser.DropComments();

        ///
                
        return parser.ParseStatement();
    }

    ///

    public static NeuStatement ParseStatement(
        this NeuParser parser) {

        switch (parser.Tokenizer.Peek()) {

            /// Declarations

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Func:
            
                return parser.ParseFuncDecl();

                ///

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Var:

                return parser.ParseVarDecl();






            /// Unary Ops

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.SizeOf:

                return parser.ParseUnaryExpression();








            /// Control flow

            case NeuKeyword keyword when keyword.KeywordType == NeuKeywordType.Return:

                return parser.ParseReturnStatement();







            /// 

            case NeuIdentifier _:

                return parser.ParseLabeledStatement();


            



            ///

            case var _ when parser.Tokenizer.MatchPrefixOperator():

                return parser.ParsePrefixExpression();







            ///

            case NeuIntegerLiteral _ when parser.ParseExpression() is NeuStatement s:

                return s;









            ///

            case var p:

                throw new Exception($"Unsupported: {p}");

        }
    }
}
