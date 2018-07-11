using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {
        List<string> student1 = new List<string> { "RoleNo1", "RoleNo5", "RoleNo3" };
        List<string> student2 = new List<string> { "RoleNo2", "RoleNo4" };
        List<string> finalStudentOrder = student1.Concat(student2).OrderBy(x => x.Substring(x.Length - 1, 1)).ToList();
        foreach (var item in finalStudentOrder)
        {
            Console.WriteLine(item);
        }

    }
}
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

}







