using System;

namespace Classes_M1_G;

public class Contact2
{
    //Read-write property with a private set accessor.
    public string Name {get; private set;}

    //Read-only property.
    public string Address {get;}

    //Private constructor
    private Contact2(string contactName, string contactAddress)
    {
        Name = contactName;
        Address = contactAddress;
    }
    
    //Public factory method
    public static Contact2 CreateContact(string contactName, string contactAddress)
    {
        return new Contact2(contactName,contactAddress);
    }

}
