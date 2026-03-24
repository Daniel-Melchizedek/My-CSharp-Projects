// See https://aka.ms/new-console-template for more information
using Classes_M1_G;

string[] names = ["Person One", "Person Two", "Person Three", "Person Four", "Person Five"];
string[] addresses = ["123 Main St.",  "345 Cypress Ave.", "678 1st Ave", "12 108th St.", "89th E. 42ND St."];

//Simple query to demonstrate object creation in select clause.
//Create Contact objects by using a constructor.
var query1 = from i in Enumerable.Range(0, names.Length)
            select new Contact(names[i], addresses[i]);
//List elements can't be modifed by client code.
var list = query1.ToList();
foreach (var contact in list)
{
    Console.WriteLine($"Name: {contact.Name}, Address: {contact.Address}");
}
//Create Contact2 objects by using a static factory method.
var query2 = from i in Enumerable.Range(0,5)
             select Contact2.CreateContact(names[i], addresses[i]);
//Console output is identical to query1.
var list2 = query2.ToList();
//List elements can't be modified by client code.
//CS0272