using System;

namespace Classes_M1_G;

public class Contact
{
    //Read-only property.
    public string Name {get;}
    //Read-write property with a private set accessor.
    public Contact()
    {
    }
    public string Address {get; private  set;}
    //Public constructor
    public Contact(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }
}
