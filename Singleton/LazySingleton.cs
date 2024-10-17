namespace design_patterns_csharp;

public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(
        () => new LazySingleton()
    );

    private LazySingleton()
    {
        Console.WriteLine("Entering private constructor.");
        Console.WriteLine("Exiting private constructor.");
    }

    public static LazySingleton Instance => _instance.Value;
}