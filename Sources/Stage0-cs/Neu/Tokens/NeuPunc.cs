
namespace Neu;

public enum NeuPuncType {

    Arrow,

    LeftParen,
    RightParen,

    LeftBrace,
    RightBrace,

    LeftBracket,
    RightBracket,

    Colon,
    Semicolon,

    Comma,
    
    Equal,
    Asterisk,
    Slash,
    Plus,
    Hyphen,

    PlusPlus,
    HyphenHyphen,

    Less,
    Greater
}

///

public partial class NeuPunc: NeuToken {

    public NeuPuncType PuncType { get; init; }

    ///

    public NeuPunc(
        Char source,
        ISourceLocation start,
        ISourceLocation end,
        NeuPuncType puncType)
        : base(new String(new Char[] { source }), start, end) {

        this.PuncType = puncType;
    }

    public NeuPunc(
        String source,
        ISourceLocation start,
        ISourceLocation end,
        NeuPuncType puncType)
        : base(source, start, end) {
            
        this.PuncType = puncType;
    }
}
