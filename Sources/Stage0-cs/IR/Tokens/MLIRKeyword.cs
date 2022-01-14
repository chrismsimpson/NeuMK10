
namespace IR;

public enum IRKeywordType {

    Func,
    Return
}

public partial class IRKeyword: IRToken {

    public IRKeywordType KeywordType { get; init; }

    ///

    public IRKeyword(
        String source,
        SourceLocation start,
        SourceLocation end,
        IRKeywordType keywordType)
        : base(source, start, end) {
            
        this.KeywordType = keywordType;
    }
}
