public class Parent
{
    private protected string SuperSecretToy {get; set;} = "Golden Dragon LEGO that lights up";
    public void ShowToFamily()
    {
        Console.WriteLine($"Parent shows:{SuperSecretToy}");
    }
}