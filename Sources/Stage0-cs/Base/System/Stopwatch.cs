
namespace Base;

public static partial class StopwatchFunctions {

    public static String GetElapsedString(
        this Stopwatch stopwatch) {

        switch (true) {

            case var _ when stopwatch.Elapsed.TotalSeconds > 1:
                return $"{stopwatch.Elapsed.TotalSeconds}s";

            ///

            default:
                return $"{stopwatch.Elapsed.TotalMilliseconds}ms";
        }
    }
}