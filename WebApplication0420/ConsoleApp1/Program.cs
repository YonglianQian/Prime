using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            DirectoryInfo di = new DirectoryInfo(@"D:\");
            foreach (var item in di.GetFiles("*.css"))
            {
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(item.FullName))
                {
                    Regex regex = new Regex(@"\b\d{1,3}rpx");
                    sb.Append(regex.Replace(sr.ReadToEnd(), new MatchEvaluator(m => 
                        string.Concat(Convert.ToInt32(m.Value.Split('r')[0]) / 2, m.Value.Split('r')[1])
                    )));
                }
                using (StreamWriter sw = new StreamWriter(item.FullName))
                {
                    sw.Write(sb.ToString());
                }
                Console.WriteLine("{0} Done!", item.Name);
            }

            Console.ReadKey();
        }
    }

 
}
