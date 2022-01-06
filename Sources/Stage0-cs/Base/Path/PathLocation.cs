
namespace Base;

public partial class PathLocation {

    public Path Path { get; init; }

    public int Position { get; set; }

    ///

    public PathLocation(
        Path path) {

        this.Path = path;
        this.Position = 0;
    }

    public PathLocation(
        Path path,
        int position) {

        this.Path = path;
        this.Position = position;
    }
}

///

public static partial class PathLocationFunctions {

    public static bool IsEof(
        this PathLocation location) {

        return location.Position == location.Path.Tokens.Count();
    }

    public static PathComponent? NextComponent(
        this PathLocation location) {

        while (!location.IsEof()) {

            var token = location.Path.Tokens.ElementAt(location.Position);
            
            location.Position++;

            if (token is PathComponent c) {

                return c;
            }
        }

        return null;
    }

    public static PathLocation ToParent(
        this PathLocation location) {

        while (location.Position >= 0) {

            var token = location.Path.Tokens.ElementAt(location.Position);

            location.Position--;

            if (token is PathComponent) {

                return new PathLocation(
                    path: new Path(
                        tokens: location.Path.Tokens.Take(location.Position)),
                    position: location.Position);
            }
        }

        return location;
    }

    public static PathLocation ToChild(
        this PathLocation location,
        PathComponent component) {

        /// Construct new path

        var rawTokens = location.Path.Tokens.Select(x => x.Source).ToList();

        var lastToken = rawTokens.Last();

        var lastIsPathSeparator = lastToken == "/" || lastToken == "\\";

        if (!lastIsPathSeparator) {

            var slashes = rawTokens.Count(x => x == "/");
            var backslashes = rawTokens.Count(x => x == "\\");

            if (slashes >= backslashes) {

                rawTokens.Add("/");
            }
            else {

                rawTokens.Add("\\");
            }
        }

        rawTokens.Add(component.Source);

        ///

        var newRawPath = Join(null, rawTokens);

        if (IsNullOrWhiteSpace(newRawPath)) {

            throw new Exception();
        }

        ///

        var parser = PathParser.FromString(newRawPath);

        var newPath = parser.ParsePath();

        ///

        var newPathLocation = new PathLocation(newPath, newPath.Tokens.Count() - 1);

        ///

        return newPathLocation;
    }

    public static PathLocation Traverse(
        this PathLocation location,
        Path dest) {

        var retVal = new PathLocation(
            path: dest, 
            position: dest.Tokens.Count() - 1);

        ///

        while (!location.IsEof()) {

            if (location.NextComponent() is PathComponent c) {

                switch (c) {

                    case ParentDirectoryComponent _:

                        retVal = retVal.ToParent();

                        break;

                    ///

                    case CurrentDirectoryComponent _:

                        // NO OP

                        break;

                    ///

                    default:

                        retVal = retVal.ToChild(c);

                        break;
                }
            }
        }

        ///

        return retVal;
    }

    public static String ToPathString(
        this PathLocation location) {
            
        return Join(null, location.Path.Tokens.Select(x => x.Source));
    }
}
