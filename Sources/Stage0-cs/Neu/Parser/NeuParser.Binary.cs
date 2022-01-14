
namespace Neu;

public static partial class NeuParserFunctions {

    public static Node ParseBinary(
        this NeuParser parser,
        SourceLocation start,
        NeuPunc? leadingPunc) {

        var expr = parser.ParseExponentiation();

        ///

        switch (parser.Tokenizer.Peek()) {

            case NeuPunc p when p.PuncType == NeuPuncType.RightBrace || p.PuncType == NeuPuncType.Semicolon:

                return expr;

            ///

            default:

                break;
        }

        ///

        if (parser.Tokenizer.PeekBinaryOperator() is NeuBinaryOperator) {

            var binaryOp = parser.Tokenizer.MaybeNextBinaryOperator();

            if (binaryOp == null) {

                throw new Exception();
            }

            ///

            var precedence = binaryOp.GetPrecedence();

            ///

            if (precedence > 0) {

                var left = expr;

                var right = parser.ParseExponentiation();

                ///

                var stack = new Stack<Node>(new Node[] { left, binaryOp, right });

                ///

                var precedences = new Stack<int>();

                precedences.Push(precedence);

                ///

                while (!parser.Tokenizer.IsEof()) {

                    var peek = parser.Tokenizer.PeekBinaryOperator();

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

                        var stackOp = stack.Pop() as NeuBinaryOperator;

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
                        
                        stack.Push(parser.ParseBinaryExpression(start, leadingPunc, left, stackOp, right));
                    }

                    ///

                    var next = parser.Tokenizer.MaybeNextBinaryOperator();

                    if (next == null) {

                        throw new Exception();
                    }

                    stack.Push(next);

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

                    var stackOp = stack.Pop() as NeuBinaryOperator;

                    if (stackOp == null) {

                        throw new Exception();
                    }

                    ///

                    left = stack.Pop();

                    if (left == null) {
                        
                        throw new Exception();
                    }

                    ///

                    expr = parser.ParseBinaryExpression(start, leadingPunc, left, stackOp, expr);
                }
            }
        }

        ///

        return expr;
    }
}
