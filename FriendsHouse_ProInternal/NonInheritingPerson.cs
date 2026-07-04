using MyFamily_ProInternal;

namespace FriendsHouse_ProInternal;
class NonInheritingPerson
{
   void DoYouKnow()
    {
        //Does not compile.
        Parent p = new Parent();
        //Console.WriteLine($"{p.FamilyRecipe}");
    }
}