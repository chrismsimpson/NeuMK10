
namespace LLIR;

public enum LLIRPuncType {

    LeftParen,
    RightParen,

    LeftBrace,
    RightBrace,

    LeftBracket,
    RightBracket
}

public partial class LLIRPunc: LLIRToken {
    
    public LLIRPuncType PuncType { get; init; }

    ///

    public LLIRPunc(
        Char source,
        SourceLocation start,
        SourceLocation end,
        LLIRPuncType puncType)
        : base(new String(new Char[] { source }), start, end) {

        this.PuncType = puncType;
    }

    public LLIRPunc(
        String source,
        SourceLocation start,
        SourceLocation end,
        LLIRPuncType puncType)
        : base(source, start, end) {
            
        this.PuncType = puncType;
    }
}