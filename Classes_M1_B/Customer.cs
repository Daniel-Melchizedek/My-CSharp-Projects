using System;

namespace Classes_M1_B;

public class Customer
{
    //Auto-implemented properties for trivial get and set.
    public double TotalPurchases { get; set; }
    public string Name {get; set;} = "FirstName";
    public int CustomerId {get; set;}

    //Constructor
    public Customer()
    {
        
    }
    public Customer(double purchases, string name, int id): this()
    {
        this.TotalPurchases = purchases;
        this.Name = name;
        this.CustomerId = id;
    }

    //Methods
    public string GetContactInfo() {return "ContactInfo"; }
    public string GetTransactionHistory() {return "History";}


}
