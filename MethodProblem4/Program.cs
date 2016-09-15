using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProblem4
{
    class Program
    {
        public static void Main()
        {
            int[] arrayA = { 12, 8, 10, 15 };
            Console.WriteLine("The sum of the array is {0}.",Sum(arrayA));

        }
        static int Sum (int[] userNums)
        {
            int sum = 0;
            for(int i = 0; i <= userNums.Length-1; i++)
            {
                sum += userNums[i];
            }            
            return sum;

        }
    }
}
