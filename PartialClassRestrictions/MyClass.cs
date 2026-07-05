public partial class MyClass<T, U> where T : class, new()
{
    public T? Item1 { get; set; }
    public U? Item2 { get; set; }

    public void Process()
    {
        Console.WriteLine($"Processing {typeof(T)} and {typeof(U)}");
    }
}

public partial class MyClass<T,U>
{
    public void Display()
    {
        Console.WriteLine($"Item1: {Item1}, Item2: {Item2}");
    }

    public void Reset()
    {
        Item1 = new T();
        Item2 = default;
    }
}