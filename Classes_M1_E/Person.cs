using System;

namespace Classes_M1_E;

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    private string? _firstName;
    public string? FirstName { get => _firstName; set{_firstName = value; _fullName = null;} }

    private string? _lastName;
    public string? LastName { get => _lastName; set { _lastName = value; _fullName = null;} }

    private string? _fullName;
    public string FullName
    {
        get
        {
            if (_fullName is null)
            {
                _fullName =  $"{_firstName}{_lastName}";
            }
            return _fullName;
        }
    }
}
