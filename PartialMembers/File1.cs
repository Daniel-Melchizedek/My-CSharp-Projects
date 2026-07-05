public partial class PropertyBag
{
    public partial int MyProperty {get; set;}
    public virtual partial void OnNameChanged(int i, int j);
}

public partial class PropertyBag
{
    public partial int MyProperty {get=> field+1; set;}

    public virtual partial void OnNameChanged(int i, int j)
    {
        Console.WriteLine("your name has been changed");
    }
    public void MyMehtod()
    {
        OnNameChanged(5,10);
    }
}

public partial class SpecializedPropertyBag : PropertyBag
{
    public new partial void OnNameChanged(int i, int j);
    public new partial void OnNameChanged(int i, int j)
    {
        Console.WriteLine("your name has been changed with specialzed instance (new)");
    }
}