using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrimeNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Please enter a number to see if that number is prime: ");
            int input = Convert.ToInt32(ReadLine());
            if (isPrime(input))
                Write(input + " is prime.");
            else
                Write(input + " is not prime.");
        }
        public static bool isPrime(int num)
        {
            if (num < 2)
                return false;
            if (num == 2)
                return true;
            for(int c=2; c<=(Convert.ToInt32(Math.Sqrt(num))); ++c)
            {
                if (num % c == 0)
                    return false;
            }
            return true;
        }
    }
}
