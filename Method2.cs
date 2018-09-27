using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class Method2
    {
        public void show()
        {
            Console.WriteLine("This is non parameterized function");
        }
        public void Shine()
        {
            Console.WriteLine("This is non parameterized function in C#");
        }
        public void Hello(int i)
        {
            Console.WriteLine("Hello :" + i);
        }
        public void Show(string message)
        {
            Console.WriteLine("Hello :" + message);
        }
        public string Say(string name)
        {
            Console.WriteLine("Inside Show Function");
            return name;
        }
        static void Main(string[] args)
        {
            Method2 a = new Method2();
            a.show();
            a.Shine();
            a.Hello(1);
            a.Show("surendra");
            String name = a.Say("Rahul Kumar");
            Console.WriteLine("Hello" + name);
            Console.Read();
        }
    }
}
