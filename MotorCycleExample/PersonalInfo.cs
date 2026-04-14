using System;

namespace MotorCycleExample;

public class PersonalInfo
{
    static void Main()
    {
        
        var person = GetPersonalInfo("Z3");
        Console.WriteLine($"{person.Item1} {person.Item2} {person.Item3} {person.Item4}");
        var person2 = GetPersonalInfo(3);
        Console.WriteLine($"{person2.FName} {person2.MName} {person2.LName} {person2.Age}");
        int[] arr = [1,2,3];
        Console.WriteLine("before arr modification:"+ string.Join(",",arr));
        ModifyArr(arr);
        Console.WriteLine("after arr modification:"+ string.Join(",",arr));

    }
    public PersonalInfo()
    {
        
    }
    public PersonalInfo(string firstName,string middleName,string lastName,int age)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.Age = age;
    }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public static void ModifyArr(int[] intArr)
    {
        intArr[1] = 42;
    }

    public static PersonalInfo RetrieveInfoById(string id)
    {
        if (id == "Z3")
        {
            return new("James", "Montamingo","Senior",30);
        }
        else
        {
            return new("Easter", "Egg","Last",30);
        }

    }

    public static (string,string,string,int) GetPersonalInfo(string id)
    {
        PersonalInfo per = PersonalInfo.RetrieveInfoById(id);
        return (per.FirstName,per.MiddleName,per.LastName,per.Age);
    }

    public static (string FName,string MName,string LName,int Age) GetPersonalInfo(int id)
    {
        PersonalInfo per = PersonalInfo.RetrieveInfoById(id.ToString());
        return (per.FirstName,per.MiddleName,per.LastName,per.Age);
    }

    
}
