// See https://aka.ms/new-console-template for more information

using ByRefTypeExample;

SampleRefType rt = new SampleRefType {value = 44};
Console.WriteLine("In Main, rt.value = {0}", rt.value);
ModifyObject(rt);
Console.WriteLine("Back in Main, rt.value = {0}",rt.value);

static void ModifyObject(SampleRefType obj)
{
    obj.value = 33;
    Console.WriteLine("In ModifyObject, obj.value = {0}", obj.value);
}
