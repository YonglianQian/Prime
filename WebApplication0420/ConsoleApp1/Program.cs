using System;
using System.Collections;
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
             "9",

         };
            //string[] arr = strlist.ToArray();
            //Array.Sort(arr, new Customcomparer());
            // string[] arr = strlist.ToArray();
            //Array.Sort(arr,new Customcomparer());

            //var re = strlist.OrderBy(p => p, new Comparer1()).ToList();
            //string[] arr = strlist.ToArray();
            //Array.Sort(arr, new Comparer1());

            var arr = strlist.OrderBy(p => p, new Comparer1());



            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class Comparer1 : IComparer<string>
    {
        public int Compare(string x, string y)
        {

            if (x != "abcd" && y != "abcd")
            {
                int a = int.Parse(x);
                int b = int.Parse(y);
                return a.CompareTo(b);
            }
            else
            {
                if (x == "abcd" && y != "abcd")
                {
                    return -1;
                }
                if (x != "abcd" && y == "abcd")
                {
                    return 1;
                }

                return 0;
            }

        }
}

}
