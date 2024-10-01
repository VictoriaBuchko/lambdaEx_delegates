using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaEx_delegates
{
    public class Task
    {
        public static void Task3(string text, string word)
        {
            Predicate<string> containsWord = (input) => input.Contains(word);
            bool result = containsWord(text);

            if (result)
            {
                Console.WriteLine($"Текст містить слово '{word}'.");
            }
            else
            {
                Console.WriteLine($"Текст не містить слово '{word}'.");
            }
        }

        public static int Task4(int[] array)
        {
            return array.Count(x => x % 7 == 0);
        }

        public static int Task5(int[] array)
        {
            return array.Count(x => x % 7 == 0);
        }

        public static void Task6(int[] array)
        {
            var uniqueNegativeNumbers = array
                .Where(x => x < 0) 
                .Distinct();

            Console.WriteLine("Унікальні негативні числа:");
            foreach (var number in uniqueNegativeNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
