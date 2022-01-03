
namespace Neu;

public static class FileStreamFunctions {

    public static void HardReset(
        this FileStream stream) {

        stream.Seek(0, SeekOrigin.Begin);

        stream.SetLength(0);
    }

    ///

    public static FileStream NewFileStream(
        String path, 
        bool readOnly) {

        switch (readOnly) {
            
            case true:

                return new FileStream(
                    path: path,
                    mode: FileMode.Open,
                    access: FileAccess.Read,
                    share: FileShare.Read,
                    bufferSize: 4096,
                    useAsync: true);

            case false:

                return new FileStream(
                    path: path,
                    mode: FileMode.OpenOrCreate,
                    access: FileAccess.ReadWrite,
                    share: FileShare.ReadWrite,
                    bufferSize: 4096,
                    useAsync: true);
        }
    }
}
