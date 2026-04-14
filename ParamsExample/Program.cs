using ParamsExample;

internal static class ParamsExampleApp
{
   public static void Main()
    {

        // string fromArray = GetVowels(["apple","banana", "pear","daniel"]);
        // Console.WriteLine(fromArray);

        // string fromMultipleArgs = GetVowels("pineapple","banyan");
        // Console.WriteLine(fromMultipleArgs);

        // string fromNull = GetVowels(null);
        // Console.WriteLine(fromNull);
        // string fromNoValue = GetVowels();
        // Console.WriteLine(fromNoValue);
        SimpleMath obj = new();
        int result = obj.AddTwoNumbers(1,2);
        result = obj.SquareANumber(result);
        Console.WriteLine(result);
        
    } 
    static string GetVowels(params IEnumerable<string>? input)
    {
        if(input == null || !input.Any())
        {
            return string.Empty;
        }
        char[] vowels = { 'A', 'E', 'I', 'O', 'U' };
        return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
    }
}