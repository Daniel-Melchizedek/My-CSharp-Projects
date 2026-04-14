using System;

namespace ExtensionMethodDemo.PersonNamespace;

public class Person
{
    //Define a simple class with properties and methods.
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {FirstName} {LastName}, and I'm {Age} years old.");
    }
    public void EmotionNow(string emotion)
    {
        Console.WriteLine($"Feeling {emotion}");
    }
}
