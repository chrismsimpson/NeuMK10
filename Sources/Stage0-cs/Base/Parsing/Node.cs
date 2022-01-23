
namespace Base;

public partial class Node {

    public IEnumerable<Node> Children { get; init; }

    public ISourceLocation Start { get; init; }

    public ISourceLocation End { get; init; }

    ///
    
    public Node(
        IEnumerable<Node> children,
        ISourceLocation start,
        ISourceLocation end) {

        this.Children = children;
        this.Start = start;
        this.End = end;
    }
}

///

public static partial class NodeFunctions {

    public static bool IsNewlineDelimited(
        this Node node,
        int threshold) {

        var newlines = node.End.LineNumber - node.Start.LineNumber;

        return newlines >= threshold;
    }

    public static T? GetFirstOrDefault<T>(
        this Node node) {

        foreach (var child in node.Children) {

            if (child is T t) {

                return t;
            }
        }

        ///

        return default(T?);
    }

    public static String GetName(
        this Node node) {

        throw new Exception();
    }

    ///
    
    public static String Dump(
        this Node node,
        int indent = 0) {

        var i = Indent(indent);

        var t = node.GetType();

        ///

        var sb = new StringBuilder();

        ///

        if (node is Token tok) {

            var sourceTrimmed = tok.Source.Trim();

            switch (tok.IsString()) {

                case true:

                    sb.Append($"{i}{t.Name} \"{sourceTrimmed}\"");

                    break;

                ///

                case false:
                    
                    sb.Append($"{i}{t.Name} {sourceTrimmed}");

                    break;
            }
        }
        else {

            sb.Append($"{i}{t.Name}");
        }

        ///

        foreach (var c in node.Children) {

            sb.Append('\n');

            sb.Append(c.Dump(indent + 1));
        }

        ///

        return sb.ToString();
    }

    ///

    private static String Indent(
        int indent) {

        var sb = new StringBuilder();

        for (var i = 0; i < indent; i++) {
            
            sb.Append(" ");
        }

        return sb.ToString();
    }
}
