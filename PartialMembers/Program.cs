PropertyBag pg = new();
SpecializedPropertyBag spg = new();
pg.MyProperty = 30;
Console.WriteLine($"my property {pg.MyProperty}");
pg.MyMehtod();
spg.MyMehtod();
spg.OnNameChanged(2,3);
PartMem.RunMethod();
