
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseOperand(
        this NeuParser parser) {

        var start = parser.Tokenizer.GetLocation();

        ///

        return parser.ParseOperand(start);
    }

    public static Node ParseOperand(
        this NeuParser parser,
        ISourceLocation start) {

        var expr = parser.ParseExponentiation();

        ///

        switch (parser.Tokenizer.Peek()) {

            case NeuPunc p when p.PuncType == NeuPuncType.Semicolon || p.PuncType == NeuPuncType.RightBrace:

                return expr;

            ///

            default:

                break;
        }

        ///

        if (parser.Tokenizer.MatchInfixOperator()) {

            var op = parser.Tokenizer.MaybeNextInfixOperator();

            if (op == null) {

                throw new Exception();
            }

            ///

            var precedence = op.GetPrecedence();

            ///

            if (precedence > 0) {

                var left = expr;

                var right = parser.ParseExponentiation();

                ///

                var stack = new Stack<Node>(new Node[] { left, op, right });

                ///

                var precedences = new Stack<int>();

                precedences.Push(precedence);

                ///

                while (!parser.Tokenizer.IsEof()) {

                    var peek = parser.Tokenizer.PeekInfixOperator();

                    if (peek == null) {

                        break;
                    }
                    
                    ///

                    precedence = peek.GetPrecedence();

                    ///

                    if (precedence <= 0) {

                        break;
                    }

                    ///

                    while (stack.Count > 2 && precedence <= precedences.Peek()) {

                        right = stack.Pop();

                        if (right == null) {

                            throw new Exception();
                        }

                        ///

                        var stackOp = stack.Pop() as NeuInfixOperator;

                        if (stackOp == null) {

                            throw new Exception();
                        }

                        ///

                        precedences.Pop();

                        ///

                        left = stack.Pop();
                        
                        if (left == null) {

                            throw new Exception();
                        }

                        ///
                        
                        stack.Push(parser.ParseInfixExpression(start, left, stackOp, right));
                    }

                    ///

                    var nextOp = parser.Tokenizer.MaybeNextInfixOperator();

                    if (nextOp == null) {

                        throw new Exception();
                    }

                    stack.Push(nextOp);

                    ///

                    precedences.Push(precedence);

                    ///

                    stack.Push(parser.ParseExponentiation());
                }

                ///

                expr = stack.Pop();

                if (expr == null) {

                    throw new Exception();
                }

                ///

                while (stack.Count > 1) {

                    var stackOp = stack.Pop() as NeuInfixOperator;

                    if (stackOp == null) {

                        throw new Exception();
                    }

                    ///

                    left = stack.Pop();

                    if (left == null) {
                        
                        throw new Exception();
                    }

                    ///

                    expr = parser.ParseInfixExpression(start, left, stackOp, expr);
                }
            }
        }

        ///

        return expr;
    }
}