using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class CallbyReference
    {
        public void Show(ref int num)
        {
            num = num + num;
            Console.WriteLine("value inside the function is:" + num);
        }
        static void Main(string[] args)
        {
            int num = 60;
            CallbyReference a = new CallbyReference();
            Console.WriteLine("Value before calling the function " + num);
            a.Show(ref num);
            Console.WriteLine("Value after calling the function " + num);
            Console.Read();
        }
    }
}
