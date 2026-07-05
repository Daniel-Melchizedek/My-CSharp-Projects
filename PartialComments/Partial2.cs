using System;
namespace PartialComments;
public partial class MyClass
{
/// <summary>
/// I'm really doing something.
/// </summary>
    public partial void DoSomething()
    {
        Console.WriteLine("I'm actually doing something.");
    }
}

public class Planet{}
public interface IRotate{}
public interface IRevolve{}

partial class Earth : Planet, IRotate { }
partial class Earth : IRevolve { }
