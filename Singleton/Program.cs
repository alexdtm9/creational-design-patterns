Console.WriteLine("Before first access");
Singleton singleton1 = Singleton.Instance;
Console.WriteLine("After first access");
Singleton singleton2 = Singleton.Instance;

// // This is also thread-safe. Comment above code and uncomment below code to see it in action.
// ParallelEnumerable.Range(0, 1000)
//     .ForAll(_ =>
//     {
//         Singleton singleton = Singleton.Instance;
//     });

sealed class Singleton
{
    private static readonly Lazy<Singleton> _lazyInstance = new(() => new());

    public static Singleton Instance => _lazyInstance.Value;

    private Singleton()
    {
        Console.WriteLine("Instantiating singleton");
    }
}