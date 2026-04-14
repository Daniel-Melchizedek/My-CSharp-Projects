using System;

namespace Classes_M1_O;

public class Person
{
    public Person()
    {
        
    }
    public Person(string name)
    {
        _name = name;
        Age = 28;
    }
    private string _name = "N/A";
    private int _age =0;
    //Declare a Name property of type string.
    public string Name 
    {
        get {return _name;}
    }
    //Declare an Age property of type int:

    public int Age
    {
        get { return _age; }
        private set { _age = value; }
    }
    
}
