
namespace Neu;

public partial class NeuSource: NeuNode {

    public NeuSource(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : base(children, start, end) { }
}

public partial class NeuSourceFile: NeuSource {

    public String Filename { get; set; }

    ///
 
    public NeuSourceFile(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end,
        String filename)
        : base(children, start, end) {

        this.Filename = filename;
    }   
}

public partial class NeuSourceMemory: NeuSource {

    public Guid Guid { get; set; }

    ///
 
    public NeuSourceMemory(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end)
        : this(children, start, end, Guid.NewGuid()) { }

    public NeuSourceMemory(
        IEnumerable<Node> children,
        SourceLocation start,
        SourceLocation end,
        Guid guid)
        : base(children, start, end) {
            
        this.Guid = guid;
    }
}