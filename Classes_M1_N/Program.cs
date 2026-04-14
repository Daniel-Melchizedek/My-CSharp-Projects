// See https://aka.ms/new-console-template for more information
using Classes_M1_N;

Employee employee1 = new Employee {Name = "NameOne"};

Console.WriteLine($"Employee1 Name: {employee1.Name}, Employee Number: {Employee.Counter}");

Employee employee2 = new Employee {Name = "NameTwo"};
Console.WriteLine($"Employee2 Name: {employee2.Name}, Employee Number: {Employee.Counter}");

employee2.Name = "NameThree";

Console.WriteLine($"Employee2 Name: {employee2.Name}, Employee Number: {Employee.Counter}");

//Keep the console window open in debug mode.
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.WriteLine(Employee.Counter);


Employee employee3 = new Employee {Name = "NameThree"};
Console.WriteLine($"Employee3 Name: {employee3.Name}, Employee Number: {Employee.Counter}");