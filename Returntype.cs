using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class Returntype
    {
        public int Say(int s)
        {
            Console.WriteLine("Hello from Server:" + s);
            return s;
        }
        static void Main(string[] args)
        {
            Returntype a = new Returntype();
            a.Say(10);
            Console.Read();
        }
    }
}
