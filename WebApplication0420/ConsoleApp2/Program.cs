using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

class Program
{

    static void Main(string[] args)
    {
  
        

    }
    
}
public class Person
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string employeeID { get; set; }
    public Position[] positions { get; set; }
}
public class Position
{
    public string position_id { get; set; }
    public string job_title { get; set; }
    public string team { get; set; }
    public Person manager { get; set; }
}







