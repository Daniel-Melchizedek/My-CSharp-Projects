using System;

namespace Classes_M1_F;

public class Contact
{
    public string Name {get;}
    public string Address {get; private set;}
    public Contact(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }

    public void ChangeName(string name)
    {
        // Name = name;
    }

    public void ChangeAddress(string newAddress)
    {
        Address = newAddress;
    }
}
