using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaEx_delegates
{
    public delegate bool NumberFilter(int number);

    public class ArrayOperations
    {

        public static int[] FilterArray(int[] array, Predicate<int> filter)
        {
            return Array.FindAll(array, filter);
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        public static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return (b == number || number == 0);
        }


    }


}
