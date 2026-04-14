// See https://aka.ms/new-console-template for more information
using Classes_M1_O;

//Create a new Person object
Person person = new Person("NameOne");

Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");


person = new Person();

Console.WriteLine($"Person details - Name = {person.Name}, Age = {person.Age}");

//Keep the console window open in debug mode.
Console.WriteLine("Press any key to exit...");
Console.ReadKey();