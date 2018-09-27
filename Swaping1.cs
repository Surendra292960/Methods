using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class Swaping1
    {
        public static void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            System.Console.WriteLine("Inside method name is {0} {1}" , s1 , s2);
        }
        static void Main(string[] args)
        {
            string name1 = "Vikas";
            string name2 = "Singh";
            Swaping1 a = new Swaping1();
            System.Console.WriteLine("before name is {0} {1}", name1 , name2);
            Swap(ref name1, ref name2);
           System.Console.WriteLine("after name is {0} {1}",name1 , name2);
            Console.Read();

        }
    }
}
