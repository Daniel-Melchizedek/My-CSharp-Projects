// See https://aka.ms/new-console-template for more information

int value = 20;
Console.WriteLine("In Main, value = {0}", value);
ByValueExample.ByValueExample.ModifyValue(value);
Console.WriteLine("Back in Main, value = {0}",value);