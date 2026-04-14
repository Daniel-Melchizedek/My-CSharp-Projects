using System;

namespace MotorCycleExample;

public class SampleRefType
{
    public int value;
}

public static class ByRefTypeExample
{
    public static void Main()
    {
        SampleRefType rt = new(){value = 44 };
        Console.WriteLine("In Main, rt.value = {0}", rt.value);
        ModifyObject(rt);
        Console.WriteLine("Back in Main, rt.value = {0}",rt.value);
    }
    static void ModifyObject(SampleRefType obj)
    {
        obj.value = 30;
        Console.WriteLine("In ModifyObject, obj.value = {0}", obj.value);
    }
}
