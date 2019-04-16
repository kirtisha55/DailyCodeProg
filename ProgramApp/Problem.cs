using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApp
{
    class Problem
    {
        /// <summary>
        /// Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        /// For example, given[10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>

        public static bool CheckNum(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                while (j < arr.Length)
                {
                    if ((arr[i] + arr[j]) == k)
                    {
                        Console.WriteLine(" 2 index - " + i + ", " + j);
                        return true;
                    }
                    j++;
                }
            }

            return false;
        }

        /// <summary>
        /// Given an array of integers, return a new array such that each element at index i of the new array is the product 
        /// of all the numbers in the original array except the one at i.
        ///For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. 
        ///If our input was[3, 2, 1], the expected output would be[2, 3, 6].
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        //approach 1-> using division
        public static int[] FindProd1(int[] arr)
        {
            List<int> res = new List<int>();
            int product = 1;

            int prod = arr.Aggregate(1, (a, b) => a * b);
            Console.WriteLine(" prod val - {0}", prod);

            foreach (var i in arr)
            {
                product *= i;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                res.Add(product / arr[j]);
            }

            return res.ToArray();
        }

        //approach 2 - without using division
        public static int[] FindProd2(int[] arr)
        {
            List<int> res = new List<int>();
            int ind = 0;
            int product = 1;
            int i = 0;
            while (ind < arr.Length)
            {
                while (i < arr.Length)
                {
                    if (i != ind)
                    {
                        product *= arr[i];
                    }
                    i++;
                }
                res.Add(product);
                product = 1;
                i = 0;
                ind++;
            }

            return res.ToArray();
        }
    }
}
