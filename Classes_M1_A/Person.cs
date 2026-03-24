using System;
using System.Diagnostics.CodeAnalysis;

namespace Classes_M1_A;

public class Person
{
    public Person()
    {}
    [SetsRequiredMembers]
    public Person(string firstName)
    {
        FirstName = firstName;
    }
    public required string FirstName {get; init;}
}
