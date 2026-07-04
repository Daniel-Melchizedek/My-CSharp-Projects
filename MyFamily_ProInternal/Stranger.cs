namespace MyFamily_ProInternal;
public class Stranger
{
    public static void Main()
    {
        TryItOut();
    }
    public static void TryItOut()
    {
        var p = new Parent();
        p.FamilyRecipe = "dan";
        Console.WriteLine($"FamilyReceipte:{p.FamilyRecipe}");
    }
}