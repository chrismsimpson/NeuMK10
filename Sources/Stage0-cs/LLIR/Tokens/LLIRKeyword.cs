
namespace LLIR;

public enum LLIRKeywordType {

    Define,
    Ret
}

public partial class LLIRKeyword: LLIRToken {

    public LLIRKeywordType KeywordType { get; init; }

    ///

    public LLIRKeyword(
        String source,
        SourceLocation start,
        SourceLocation end,
        LLIRKeywordType keywordType)
        : base(source, start, end) {
            
        this.KeywordType = keywordType;
    }
}
