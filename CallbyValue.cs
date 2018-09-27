using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class CallbyValue
    {
        public void Show(int value)
        {
            value = value*value;
            Console.WriteLine("value inside the function is:" + value);
        }

        static void Main(String[] arsgs)
        {
             int value = 50;
            CallbyValue a = new CallbyValue();
            Console.WriteLine("Value before calliing:" + value);
            a.Show(value);
            Console.WriteLine("Value after calliing:" + value);
            Console.Read();
        }
    }
}
