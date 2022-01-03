
namespace Neu;

public interface IToken {

}

public partial class Token: Node, IToken {

    public String Source { get; init; }

    ///

    public Token(
        Char source,
        SourceLocation start,
        SourceLocation end)
        : base(new Node[] { }, start, end) {

        this.Source = new String(new [] { source });
    }

    public Token(
        String source,
        SourceLocation start, 
        SourceLocation end)
        : base(new Node[] { }, start, end) {

        this.Source = source;
    }
}

///

public static partial class TokenFunctions {

    public static bool ContainsNewline(
        this Token token) {

        return token.End.LineNumber > token.Start.LineNumber;
    }

    public static bool IsString(
        this Token token) {

        switch (token) {
            
            ///

            default:
                return false;
        }
    }
}
