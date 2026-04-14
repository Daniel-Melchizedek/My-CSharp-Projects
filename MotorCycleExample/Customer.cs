using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace MotorCycleExample;

public class Customer
{
    public static void Main()
    {
        Customer c = new Customer();
        c.FirstName = "Jone";
        c.LastName = "Doe";
        Customer c2 = c[100];
        Console.WriteLine(c2.Name);
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    private int _x, _y;
    public Point Move(int dx, int dy) => new Point(_x+dx, _y+dy);
    public void Print() => Console.WriteLine(FirstName + " " + LastName);
    //Works with operators, properties, and indexers too.
    // public static Complex operator +(Complex c1, Complex c2) => c1.Add(c2);
    public string Name => FirstName +" "+LastName;
    public Customer this[long id] => this;
}
