
namespace Neu;

public partial class NeuArray: NeuValuePrimitive {

    public IEnumerable<NeuOperation> Elements { get; init; }

    ///

    public NeuArray(
        IEnumerable<NeuOperation> elements)
        : base() {

        this.Elements = elements;
    }
}

///

public static partial class NeuArrayFunctions {

    public static NeuOperation? ElementAt(
        this NeuArray array,
        int index) {

        return array.Elements.ElementAt(index);
    }
}
