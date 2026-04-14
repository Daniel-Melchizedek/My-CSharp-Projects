// See https://aka.ms/new-console-template for more information
using MotorCycleExample;

//Call with an int variable.
int num = 4;
int productA = SquareExample.Square(num);
Console.WriteLine(productA);

//Call with an integer literal.
int productB = SquareExample.Square(12);
Console.WriteLine(productB);


//Call with an expression that evaluates to int.
int productC = SquareExample.Square(productA * 3);
Console.WriteLine(productC);