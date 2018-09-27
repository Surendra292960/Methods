using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class InstanceMethod
    {
            public void DoSomething()
            {
            Console.WriteLine("DoSomething");           
            }
            public void DoSomethingElse()
            {
                this.DoSomething();
            Console.WriteLine("DoSomethingElse");
        }
        
    public class ProgramInstanceMethod
        {
        static void Main()
        {
                InstanceMethod a = new InstanceMethod();
                a.DoSomething();
                a.DoSomethingElse();
                Console.Read();
        }
       }
    }
}
