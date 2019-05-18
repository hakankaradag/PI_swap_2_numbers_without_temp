using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PI_change_two_numbers_without_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Stack yigin = new Stack();

            yigin.Push(a);
            yigin.Push(b);

            a = (int)yigin.Pop();
            b = (int)yigin.Pop();

            Console.WriteLine ("The value of the 1st variable {0}" ,a);
            Console.WriteLine("The value of the 2st variable {0}", b);
            Console.ReadKey();





        }
    }
}
