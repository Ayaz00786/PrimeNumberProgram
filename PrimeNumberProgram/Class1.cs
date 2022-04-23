using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberProgram
{
    internal class Class1
    {
        public static void prime()
        {
            int count = 0;
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is Not Prime Number");
                    count = 1;
                    break;
                }

            }


            if (count == 0)
            {
                Console.WriteLine("Number is Prime Number");
            }
            Console.ReadLine();
        }
    }
}
