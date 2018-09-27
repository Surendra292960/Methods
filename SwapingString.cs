using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class SwapingString
    {
         static void Change(ref String s1, ref String s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            System.Console.WriteLine("Inside the method: {0} {1}", s1, s2);
        }


        static void Main(string[] args)
        {
            string string1 = "Surendra";
            string string2 = "Pal";

            System.Console.WriteLine("Inside the main method before execution: {0} {1}", string1, string2);
            Change(ref string1, ref string2);
            System.Console.WriteLine("Inside the main method before execution: {0} {1}", string1, string2);
            Console.Read();

        }
    }
}