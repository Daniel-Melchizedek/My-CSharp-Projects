using ExtensionMethodDemo.PersonExtensionsNamespace;
using ExtensionMethodDemo.PersonNamespace;
//Create instances of the Person class
Person person1 = new Person {FirstName = "FName1", LastName = "LName1", Age= 25};
Person person2 = new Person {FirstName = "Fname2", LastName = "LName2", Age = 16 };

//Use the methods of the Person class
person1.Introduce();
person2.Introduce();

//Use the extension methods
person1.DisplayFullName();
Console.WriteLine($"Is {person1.FirstName} an adult? {person1.IsAdult()}");

person2.DisplayFullName();
Console.WriteLine($"Is {person2.FirstName} an adult? {person2.IsAdult()}");

//Use the extension method that attempts to override Introduce
person1.Introduce("Hey");
person2.Introduce("Greetings");
// PersonExtensions.Introduce();
person1.EmotionNow("Happy");