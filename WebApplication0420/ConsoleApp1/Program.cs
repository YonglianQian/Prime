using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String startPlusText = " is or are"; //
            String tableText = " table(s)";
            String tableTextPlus = " on the table";
            String chairText = " chair";
            String chairTextPlus = " at the chair";
            var typeCount = 0;

            StringBuilder strBuild = new StringBuilder();
            StringBuilder strBuildPlus = new StringBuilder();
            string strPer="", strPerPlus="";


            bool something = true;
            bool somthingEsle = true;
            bool isFirst = true;

            if (something == true)
            {
                typeCount++;
                if (somthingEsle == true)
                {
                    typeCount++;
                    if (isFirst)
                    {
                        isFirst = false;
                        strBuild.Append(tableText);
                        strBuildPlus.Append(startPlusText);
                        strBuildPlus.Append(tableTextPlus);
                        if (typeCount == 2)
                        {
                            strBuild.Append(", and ");
                            strBuildPlus.Append("(s), ");
                        }
                        //else if (typeCount - 1 == 0) //last one
                        //{
                        //    strBuildPlus.Append(", ");

                        //}
                        //typeCount = typeCount - 1;

                        strBuild.Append(chairText);
                        strBuildPlus.Append(chairTextPlus);
                        strPer = strBuild.ToString();
                        strPerPlus = strBuildPlus.ToString();
                    }
                }
            }
            Console.WriteLine(strPer);
            Console.WriteLine(strPerPlus);
        }
    }
}
