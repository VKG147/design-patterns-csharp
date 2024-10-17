namespace design_patterns_csharp;

public sealed class StaticConstructorSingleton
{
    private static readonly StaticConstructorSingleton _instance;

    static StaticConstructorSingleton()
    {
        System.Console.WriteLine("Entering static constructor.");
        _instance = new();
        System.Console.WriteLine("Exiting static constructor.");
    }

    private StaticConstructorSingleton()
    {
        System.Console.WriteLine("Entering private constructor.");
        System.Console.WriteLine("Exiting private constructor.");
    }

    public static StaticConstructorSingleton Instance => _instance;
}
