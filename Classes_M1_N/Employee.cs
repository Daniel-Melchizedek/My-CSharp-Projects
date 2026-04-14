using System;

namespace Classes_M1_N;

public class Employee
{
    private static int _counter;
    private string _name;

    //A read-write instance property:
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    //A read-only static property:
    public static int Counter => _counter;

    //A Constructor
    public Employee()
    {
        ++_counter; //Calculate the employee's number:
    }

}
