namespace MyFamily_ProInternal;
public class Parent
{
    protected internal string FamilyRecipe {get; set;} = "Chocolate Cake";
    public void ShareRecipe()
    {
        Console.WriteLine($"Parent says: {FamilyRecipe}");
    }
}