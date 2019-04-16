using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 15, 3, 7};
            int num = 17;
            bool result = Problem.CheckNum(a, num);
            Console.WriteLine(" Result - " + result);
            
            int[] res2 = Problem.FindProd2(new int[] { 1, 2, 3, 4, 5, 0 });
            int[] res3 = Problem.FindProd2(new int[] { 3,2,1});

            int[] res12 = Problem.FindProd1(new int[] { 1, 2, 3, 4, 5 });
            int[] res13 = Problem.FindProd1(new int[] { 3, 2, 1 });

            foreach (var n in res2)
            {
                Console.WriteLine(" New array  - " + n);
            }
            Console.WriteLine("- --------------------- ");
            foreach (var n in res3)
            {
                Console.WriteLine(" New array  - " + n);
            }
            Console.WriteLine("==========================");
            foreach (var n in res12)
            {
                Console.WriteLine(" New array 1 - " + n);
            }
            Console.WriteLine("- --------------------- ");
            foreach (var n in res13)
            {
                Console.WriteLine(" New array 1 - " + n);
            }

            Console.ReadKey();

        }
    }
}
