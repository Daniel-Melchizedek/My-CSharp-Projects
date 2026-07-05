using PartialClassRestrictions1;
// using PartialClassRestrictions2;

Console.WriteLine("Hello, World!");
A t = new A();
t.Name = "dan";
//t.Age = 

MyClass<A,string> mc = new();

mc.Item1 = new A();
mc.Item2 = "d";

mc.Process();
mc.Display();
mc.Reset();
Outer.Inner oi = new Outer.Inner();
oi.Show();
