
namespace Base;

public partial class Option: IArgument {

    public OptionName Name { get; init; }

    public IEnumerable<Argument> Args { get; init; }

    ///

    public Option(
        OptionName name,
        IEnumerable<Argument> args) {

        this.Name = name;
        this.Args = args;
    }
}

///

public static partial class OptionFunctions {

    public static String GetString(
        this Option option) {

        return option.Name.Source;
    }
}
