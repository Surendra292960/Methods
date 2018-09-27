using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Methods
{
    class Callbyrference2
    {
        //static void Change(ref int[] pArray)
        //{
        //    pArray[0] = 444;
        //    pArray = new int[5] { -3, -1, -2, -3, -4 };
        //    System.Console.WriteLine("Inside the method, the first element is:"+ pArray[0]);
        //}

        //static void Main()
        //{
        //    int[] arr = { 1, 4, 5 };
        //    System.Console.WriteLine("Inside Main, before calling the method, the first element is:" + arr[0]);
        //    Change(ref arr);
        //    System.Console.WriteLine("Inside Main, after calling the method, the first element is:"+ arr[0]);
        //    Console.Read();
        //}

        static void Change(ref int[] pArray)
        {
            pArray[0] = 44;
            pArray = new int[5] { 2, 3, 5, 7, 9 };
            Console.WriteLine("Inside method first Elements:" + pArray[0]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine("Inside main method first Elements:" + arr[0]);
            Change(ref arr);
            Console.WriteLine("Inside main method after exicution first Elements:" + arr[0]);
            Console.Read();

        }
    }

}

