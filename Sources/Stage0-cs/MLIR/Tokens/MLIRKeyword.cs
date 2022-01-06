
namespace MLIR;

public enum MLIRKeywordType {

    Func,
    Return
}

public partial class MLIRKeyword: MLIRToken {

    public MLIRKeywordType KeywordType { get; init; }

    ///

    public MLIRKeyword(
        String source,
        SourceLocation start,
        SourceLocation end,
        MLIRKeywordType keywordType)
        : base(source, start, end) {
            
        this.KeywordType = keywordType;
    }
}
