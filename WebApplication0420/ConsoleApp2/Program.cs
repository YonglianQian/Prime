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
        object o = null;
        Console.WriteLine(o??"0");
        
        Console.WriteLine(Math.Round(1.4).ToString("0.00"));
        Console.WriteLine(Math.Round(1.6).ToString("0.00"));
        Console.WriteLine(String.Format("{0:F}", Math.Round(1.5)));
    
        Console.ReadKey();
        

    }

    

}
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }

}







