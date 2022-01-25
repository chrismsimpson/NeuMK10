
namespace Neu;

public partial class NeuCodeGenerator {

    public StringBuilder Builder { get; init; }

    ///

    public NeuCodeGenerator() {

        this.Builder = new StringBuilder();
    }
}

///

public static partial class NeuCodeGeneratorFunctions { 

    public static void Append(
        this NeuCodeGenerator generator,
        String input) {
        
        generator.Builder.Append(input);
    }

    ///

    public static void ToString(
        this NeuCodeGenerator generator) {

        generator.Builder.ToString();
    }

    ///

    public static void Generate(
        this NeuCodeGenerator generator,
        Node node) {

        foreach (var child in node.Children) {

            switch (child) {

                case NeuToken t:

                    generator.Generate(t);

                    break;

                ///



                default:

                    generator.Generate(child);

                    break;
            }

        }
    }


    // public static void Generate(
    //     this NeuCodeGenerator generator,
    //     Node node) {

    //     switch (node) {

    //         ///

    //         case NeuNode neuNode:

    //             generator.Generate(neuNode);

    //             return;

    //         ///

    //         case NeuToken token:

    //             generator.Generate(token);

    //             return;



    //         ///

    //         default:

    //             throw new Exception();
    //     }
    // }

    // public static void Generate(
    //     this NeuCodeGenerator generator,
    //     NeuNode node) {

    //     switch (node) {

    //         case NeuDeclaration decl:

    //             generator.Generate(decl);

    //             return;

    //         ///

    //         case NeuFuncSignature funcSig:

    //             generator.Generate(funcSig);

    //             return;

    //         ///


    //         default:

    //             throw new Exception();
    //     }
    // }

    // public static void Generate(
    //     this NeuCodeGenerator generator,
    //     NeuFuncSignature funcSignature) {

        

    //     throw new Exception();
    // }

    // public static void Generate(
    //     this NeuCodeGenerator generator,
    //     NeuDeclaration decl) {

    //     switch (decl) {

    //         case NeuFuncDecl funcDecl:

    //             generator.Generate(funcDecl);

    //             return;

    //         ///

    //         default:

    //             throw new Exception();

    //     }

    // }

    // public static void Generate(
    //     this NeuCodeGenerator generator,
    //     NeuFuncDecl funcDecl) {

    //     foreach (var child in funcDecl.Children) {

    //         generator.Generate(child);
    //     }

    //     // throw new Exception();
    // }

    public static void Generate(
        this NeuCodeGenerator generator,
        NeuToken token) {

        switch (token) {

            case NeuPunc p:

                generator.Generate(p);

                return;

            ///

            case NeuKeyword keyword:

                generator.Generate(keyword);

                return;

            ///

            case NeuIdentifier id:

                generator.Generate(id);

                return;
                
            ///

            default:

                throw new Exception();
        }
    }

    public static void Generate(
        this NeuCodeGenerator generator,
        NeuPunc p) {

        switch (p.PuncType) {

            case NeuPuncType.Arrow:
                
                generator.Append($" {p.Source} ");

                return;

            ///

            case NeuPuncType.LeftBrace:

                generator.Append($" {p.Source}\n");

                return;

            ///

            case NeuPuncType.RightBrace:

                generator.Append($"\n{p.Source}");

                return;

            ///

            default:

                generator.Append($"{p.Source}");

                return;
        }
    }

    public static void Generate(
        this NeuCodeGenerator generator,
        NeuIdentifier id) {

        generator.Append($"{id.Source}");
    }

    public static void Generate(
        this NeuCodeGenerator generator,
        NeuKeyword keyword) {

        switch (keyword.KeywordType) {

            case NeuKeywordType.Func:

                generator.Append($"{keyword.Source} ");

                return;

            ///

            case NeuKeywordType.Return:

                generator.Append($"\n    {keyword.Source} ");

                return;

            ///

            case NeuKeywordType.True:

                generator.Append($"{keyword.Source}");

                return;

            ///

            default:

                throw new Exception();
        }
    }
}