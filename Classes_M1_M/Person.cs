using System;

namespace Classes_M1_M;

public class Person
{
    private string _name = "Hello";
    public string Name {
        get
        {
            return _name;
        } 
        protected set
        {
            _name = value;
        }
        }
}
