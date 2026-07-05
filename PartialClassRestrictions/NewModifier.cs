public class BaseOuter
{
    public class Inner
    {
        public void Show() => Console.WriteLine("From Base");
    }
}

public partial class Outer: BaseOuter
{

}

public partial class Outer: BaseOuter
{
    public new partial class Inner
    {
        public void Show() => Console.WriteLine("new keyword in nested : From Derived");
    }
}