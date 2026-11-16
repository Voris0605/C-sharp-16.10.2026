using System.Data.Common;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Student
{
    public int id {get; set;}

    public string Name {get; set;}

    public int Age {get; set;}

    public double Avg {get; set;}

    public void GetInfo()
    {
        System.Console.WriteLine($"Id = {id}");
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Age: {Age}");
        System.Console.WriteLine($"Average Grades: {Avg}");
    }
    public bool IsExcellentStudent()
    {
        if(Avg >= 4.0)
        {
            System.Console.WriteLine("Excellent");
            return true;
        }
        else
        {
            System.Console.WriteLine("Bad");
            return false;
        }
    }
}