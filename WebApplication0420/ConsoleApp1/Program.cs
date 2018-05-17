using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> strlist = new List<string>()
         {
             "abcd",
             "10",
             "3",
             "16",
             "9"
         };
            //string[] arr = strlist.ToArray();
            //Array.Sort(arr, new Customcomparer());
            // string[] arr = strlist.ToArray();
            //Array.Sort(arr,new Customcomparer());

            var re = strlist.OrderBy(p => p, new Comparer1()).ToList();




            foreach (var item in re)
            {
                Console.WriteLine(item);
            }


        }
    }
    public class Comparer1 : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x=="abcd"||y=="abcd")
            {
                return 0;
            }
            else
            {
                int a = int.Parse(x);
                int b = int.Parse(y);
                return a.CompareTo(b);
            }
            
        }
    }

}
