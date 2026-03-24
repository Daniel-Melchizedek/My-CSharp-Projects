// See https://aka.ms/new-console-template for more information
using Classes_M1_B;
//Initialize a new Object.
Customer cust1 = new Customer();

Console.WriteLine("{0}, {1}",cust1.TotalPurchases, cust1.Name);
//Modify a property.
cust1.TotalPurchases +=499.99;
Console.WriteLine("{0}, {1}",cust1.TotalPurchases, cust1.Name);
