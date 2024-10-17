namespace design_patterns_csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start of program.");
        Singleton();
        Console.WriteLine("End of program.");
    }

    static void Singleton()
    {
        var ins = LazySingleton.Instance;
    }
}
