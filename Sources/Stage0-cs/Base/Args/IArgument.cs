
namespace Base;

public interface IArgument { }

///

public static partial class IArgumentFunctions {

    public static IEnumerable<IArgument> ToArguments(
        this IEnumerable<String> args) {

        var parser = ArgsParser.FromArgs(args);

        var arguments = parser.ParseArguments();
        
        return arguments;
    }

    ///

    public static String? Get(
        this IEnumerable<IArgument> arguments,
        String source) {

        foreach (var argument in arguments) {

            if (argument is Option option) {

                if (option.Name.Source == source) {

                    if (option.Args.Count() == 0) {

                        return option.Name.Source;
                    }
                    else {

                        return option.Args.FirstOrDefault()?.Source;
                    }
                }
            }
        }

        ///

        return null;
    }

    ///

    public static IEnumerable<IArgument> DropArguments(
        this IEnumerable<IArgument> arguments,
        int number) {

        var c = 0;

        foreach (var argument in arguments) {

            switch (argument) {

                case Argument a when c < number:

                    c++;

                    break;

                ///

                default:

                    yield return argument;

                    break;
            }
        }
    }

    ///

    public static bool AnyArguments(
        this IEnumerable<IArgument> arguments,
        int drop) {

        foreach (var argument in arguments.DropArguments(number: drop)) {

            if (argument is IArgument a) {

                return true;   
            }
        }

        ///

        return false;
    }

    ///

    public static String? GetFirstArgumentSource(
        this IEnumerable<IArgument> arguments) {

        return arguments.GetArgumentSource(distance: 0);
    }

    public static String? GetArgumentSource(
        this IEnumerable<IArgument> arguments,
        int distance) {

        foreach (var argument in arguments.DropArguments(number: distance)) {
                
            if (argument is Argument a) {

                return a.Source;
            }
        }

        ///

        return null;
    }

    ///

    public static bool Contains(
        this IEnumerable<IArgument> arguments,
        String source) {

        foreach (var argument in arguments) {

            switch (argument) {

                case Option option when option.Name.Source == source:

                    return true;

                ///

                case Argument a when a.Source == source:

                    return true;

                ///

                default:

                    continue;    
            }
        }

        ///

        return false;
    }

    public static String[] ToArgs(
        this IEnumerable<IArgument> arguments) {

        var args = new List<String>();

        ///

        foreach (var argument in arguments) {

            switch (argument) {

                case Argument arg:

                    args.Add(arg.Source);

                    break;

                ///

                case Option option:

                    args.Add(option.Name.Source);

                    foreach (var a in option.Args) {

                        args.Add(a.Source);
                    }

                    break;

                ///
                
                default:

                    break;
            }
        }

        ///

        return args.ToArray();
    }
}
