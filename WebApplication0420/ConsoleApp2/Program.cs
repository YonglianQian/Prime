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
        string path = "‪D:\\Images\\1.txt";
        
        string dir = Path.GetDirectoryName(path);
        string name = Path.GetFileName(path);
        
        string destination = "D:\\1";
        File.Copy(Path.Combine(dir, name), Path.Combine(destination, name), true);

        Console.ReadKey();
    }
    
}







