
namespace Neu;

public partial class NeuOperation {

    public static readonly NeuOperation Void = new NeuVoid();
}

///

public partial class NeuVoid: NeuOperation {

    public NeuVoid()
        : base(null, null, null, null, null, false, false) { }
}
