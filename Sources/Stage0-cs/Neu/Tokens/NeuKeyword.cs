
namespace Neu;

public enum NeuKeywordType {

    Func,
    Return,
    Var,
    Let
}

public partial class NeuKeyword: NeuToken {

    public NeuKeywordType KeywordType { get; init; }

    ///

    public NeuKeyword(
        String source,
        SourceLocation start,
        SourceLocation end,
        NeuKeywordType keywordType)
        : base(source, start, end) {
            
        this.KeywordType = keywordType;
    }
}
