public static class RefSwapExample
{
    static void Main()
    {
        int i = 2, j = 3;
        Console.WriteLine("Main: i = {0}, j = {1}", i, j);
        Swap(i, j);
        Console.WriteLine("Main: After Swap, i = {0}, j = {1}", i, j);
    }
    static void Swap( int x,  int y)
    {
       (x,y) = (y, x);
       Console.WriteLine("Swap: After Swap, x = {0}, y = {1}", x, y);
    }
}