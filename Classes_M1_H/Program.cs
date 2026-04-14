// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> s = [];
var result = from i in Enumerable.Range(0,s.Count)
select s[i];
Console.WriteLine(result.ToString());