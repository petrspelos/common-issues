// This class contains an extension method to any IEnumerable.
// This will allow you to append "PickRandom()" to any collection.

// You can place the method inside any class that is static.
// For an example here, we create a new "Extensions" class.
public static class Extensions
{
    // This class is using a ThreadStatic Random.
    // this means each thread will get its own
    // Random instance.
    
    // Seeding each Random per thread would result
    // in a more true Randomness, however, this is
    // not the goal of this snippet.
    [ThreadStatic] private static Random _rnd;

    // An accessor is implemented to ensure each
    // thread uses an initialized random.
    public static string Rnd
    {
        get
        {
            if (_rnd is null) { _rnd = new Random(); }
            return _rnd;
        }
    }

    public static T PickRandom<T>(this IEnumerable<T> collection)
        => collection.ElementAt(Rnd.Next(0,collection.Count()));
}

// =====================================
// Usage:
public class UsageDemonstration
{
    public void Foo()
    {
        var choices = new []{ "one", "two", "three" };
        var random = choices.PickRandom();
    }
}
