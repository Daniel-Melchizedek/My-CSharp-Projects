using System;
using ExtensionMethodDemo.PersonNamespace;

namespace ExtensionMethodDemo.PersonExtensionsNamespace;

public static class PersonExtensions
{
    public static void DisplayFullName(this Person person)
    {
        Console.WriteLine($"Full Name: {person.FirstName} {person.LastName}");
    }
    public static bool IsAdult(this Person person) => person.Age >=18;

    public static void Introduce(this Person person)
    {
        Console.WriteLine($"Extension - Hi, it's nice to meet you.");
    }
    //Extension method attempting to override Introduce
    public static void Introduce(this Person person, string greeting)
    {
        Console.WriteLine($"{greeting}, I'm {person.FirstName} {person.LastName}, and I'm {person.Age} years old");
    }
    public static void EmotionNow(this Person person, string emotion)
    {
        Console.WriteLine($"Extension: Feeling very {emotion}");
    }
    
}
