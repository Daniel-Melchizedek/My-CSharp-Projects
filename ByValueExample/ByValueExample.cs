using System;

namespace ByValueExample;

public static class ByValueExample
{
  internal static void ModifyValue(int i)
    {
        i = 30;
        Console.WriteLine("In ModifyValue, parameter value = {0}",i);
        return;
    }
}
