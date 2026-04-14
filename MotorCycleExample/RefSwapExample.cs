using System;
using System.Globalization;

namespace MotorCycleExample;

public static class RefSwapExample
{
    static void Main()
    {
        int i=2,j=3;
        Console.WriteLine("i={0} j={1}",i,j);
        Swap(ref i,ref  j);
        Console.WriteLine("i={0} j={1}",i,j);
    }

    static void Swap(ref int x,ref int y) => (y,x) = (x,y);
}
