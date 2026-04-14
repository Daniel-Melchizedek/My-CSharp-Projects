using System;

namespace MotorCycleExample;

public class ParamsExample
{
    static void Main()
    {
        string fromArray = GetVowels(["apple","banana","pear"]);
        Console.WriteLine($"Vowels from Array:{fromArray}");
        string fromMultipleArgs = GetVowels("apple","banana","pear");
        Console.WriteLine($"Vowels from multiple args: {fromMultipleArgs}");
        string fromNull = GetVowels(null);
        Console.WriteLine($"Vowels from null: {fromNull}");
        string fromNoValue = GetVowels();
        Console.WriteLine($"Vowels from no value:{fromNoValue}");

    }
    static string GetVowels(params IEnumerable<string>? input)
    {
        if (input == null || !input.Any())
        {
            return string.Empty;
        }
        char[] vowels = ['A','E','I','O','U'];
        return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
    }
}
