namespace design_patterns_csharp;

public sealed class EagerLoadedSingleton
{
    private static readonly EagerLoadedSingleton _instance = new();

    private EagerLoadedSingleton()
    {
        System.Console.WriteLine("Entering private constructor.");
        System.Console.WriteLine("Exiting private constructor.");
    }

    public static EagerLoadedSingleton Instance => _instance;
}
