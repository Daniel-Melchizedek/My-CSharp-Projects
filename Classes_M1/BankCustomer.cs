using System;

namespace Classes_M1;

public class BankCustomer
{
    private static int s_nextCustomerId;

    private string field;
    public string FirstName {get => field ?? "NA"; set => field=value;}
    public string LastName = "Shao";
    public readonly string CustomerId;

    static BankCustomer()
    {
        Random random = new Random();
        s_nextCustomerId = random.Next(1000000000, 2000000000);
    }

    public BankCustomer()
    {
        field = "Headset";
        this.CustomerId = (s_nextCustomerId++).ToString("D10");
    }
    public BankCustomer(string firstName, string lastName):this()
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
}
