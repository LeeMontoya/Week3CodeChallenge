using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            FindManyPrimes(10001);
            Console.ReadKey();
            
        }

        static void FindManyPrimes(int thisMany)
        {
            int curNum = 2;
            int numPrimes = 0;

            while (numPrimes < thisMany)
            {
                if (IsPrime(curNum))
                {
                    numPrimes += 1;
                }

                curNum += 1;
            }

            Console.WriteLine(curNum);
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
			{
                if (number % i == 0)
                {
                    return false;
                }

            }
            {
                return true;
            }
        }
        

     }
}
