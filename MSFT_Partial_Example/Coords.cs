public partial class Coords
{
    private int x;
    private int y;
    public Coords(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public partial class Coords
{
    public void PrintCoords()
    {
        Console.WriteLine("Coords: {0} {1}",x, y);
    }
}