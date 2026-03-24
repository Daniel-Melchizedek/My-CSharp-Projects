using System.Diagnostics.CodeAnalysis;

namespace Classes_M1_D;

public class Person
{
    public Person()
    {}

    [SetsRequiredMembers]
    public Person(string firstName, string lastName):this()
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public required string FirstName { get; init; }
    public required string LastName { get; init; }

    private string? _fullName;
    public string FullName
    {
        get
        {
            if (_fullName is null)
            {
                _fullName = $"{FirstName} {LastName}";
            }
            return _fullName;
        }
    }
}
