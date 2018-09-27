using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class OutParameter
    {
       public void Show(out int val)
        {
            int square=5;
            val = square;
            val *= val;

        }
        static void Main(string[] args)
        {
            int val=50;
            OutParameter a = new OutParameter();
            Console.WriteLine("Inside Main method before out:" + val);
            a.Show(out val);
            Console.WriteLine("Inside Main method after out:" + val);
            Console.Read();
        }
    }
}
