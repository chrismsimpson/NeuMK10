
namespace Neu;

public partial class NeuHoist {

    public NeuKeywordType KeywordType { get; init; }

    public String Name { get; init; }

    ///

    public NeuHoist(
        NeuKeywordType keywordType,
        String name) {

        this.KeywordType = keywordType;
        this.Name = name;
    }
}