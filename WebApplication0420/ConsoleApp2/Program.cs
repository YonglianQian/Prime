using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading;

class Program
{

    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student(){Id=1,Name="Steve",Age=13 },
            new Student{Id=2,Name="Abraham",Age=12 },
            new Student{Id=3,Name="Lucy",Age=15 },
            new Student{Id=4,Name="Smith",Age=18 }
        };
        var result = from s in students
                     where s.Id >= 2
                     orderby s.Age
                     select new { s.Name, s.Age };
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();

    }
    
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

}







