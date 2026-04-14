using System;

namespace Classes_M1_L;

public class Person
{
    public Person(){}
    public Person(string firstName):this()
    {
        FirstName = firstName;
    }
    public string? FirstName { get; init; }
}
