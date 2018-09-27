using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    public static class ExtensionMethod1
    {
        public static string UppercaseFirstLetter(this string value)
        {
           
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                array[9] = char.ToUpper(array[9]);
                return new string(array);
            }
            return value;
        }
        class ExtensionMethod12
        {
            static void Main()
            {
                Console.WriteLine("Enter Your Name");
                String value = Console.ReadLine();
                value = value.UppercaseFirstLetter();
                Console.WriteLine(value);

                //string value = "deeksha sharma";
                //value = value.UppercaseFirstLetter();
                //Console.WriteLine(value);
                Console.Read();
            }
        }
    }
}

