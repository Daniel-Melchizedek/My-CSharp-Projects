using System;

namespace MotorCycleExample;

public class SimpleMathExtension
{
    static void Main()
    {
        SimpleMath m = new SimpleMath();
        int result = m.AddTwoNumbers(2,3);
        result = m.SquareNumber(result);
        Console.WriteLine(result);

        result = m.SquareNumber(m.AddTwoNumbers(1,2));
        Console.WriteLine(result);
        SimpleMathExtension me = new();
        var result2 = me.DivideTwoNumbers(6,2);
        Console.WriteLine(result2);

    }
    public int DivideTwoNumbers(int number1, int number2)
    {
        return number1/number2;
    }
}
