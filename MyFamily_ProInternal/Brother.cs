namespace MyFamily_ProInternal;
public class Brother : Parent
{
    public void ShowRecipe()
    {
        Console.WriteLine($"Brother knows the secret: {FamilyRecipe}");
    }
}