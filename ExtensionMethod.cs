using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    public static class ExtensionMethod
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "123456";
            int num = str.IntegerExtension();
            Console.WriteLine("The output using extension method: {0}", num);
            Console.ReadLine();
        }
    }
}

