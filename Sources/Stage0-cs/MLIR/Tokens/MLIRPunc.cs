
namespace MLIR;

public enum MLIRPuncType {

    LeftParen,
    RightParen,

    LeftBrace,
    RightBrace,

    LeftBracket,
    RightBracket
}

public partial class MLIRPunc: MLIRToken {
    
    public MLIRPuncType PuncType { get; init; }

    ///

    public MLIRPunc(
        Char source,
        SourceLocation start,
        SourceLocation end,
        MLIRPuncType puncType)
        : base(new String(new Char[] { source }), start, end) {

        this.PuncType = puncType;
    }

    public MLIRPunc(
        String source,
        SourceLocation start,
        SourceLocation end,
        MLIRPuncType puncType)
        : base(source, start, end) {
            
        this.PuncType = puncType;
    }
}