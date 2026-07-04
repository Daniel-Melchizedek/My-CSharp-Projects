using MyFamily_ProInternal;
namespace FriendsHouse_ProInternal;
public class Child: Parent
{
    public void TellMyFriends()
    {
        Console.WriteLine($"Child says: I know the family recipe - {FamilyRecipe}");
    }
}