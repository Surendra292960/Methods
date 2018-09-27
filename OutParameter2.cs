using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class OutParameter2
    {
        public void Show(out int val1, out int val2)
        {
            int square = 5;
            val1 = square;
            val2 = square;

            val1 *= val1;
            val2 *= val2;
        }

        static void Main(string[] args)
        {
            int val1 = 50, val2 = 30;
            OutParameter2 a = new OutParameter2();
            Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            a.Show(out val1, out val2);
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);
            Console.Read();
        }
    }
}
