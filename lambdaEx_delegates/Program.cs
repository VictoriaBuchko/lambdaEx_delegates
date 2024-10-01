using System;

namespace lambdaEx_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Виберіть завдання (1-6): ");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    HandleTask1();
                    break;
                case 2:
                    HandleTask2();
                    break;
                case 3:
                    HandleTask3();
                    break;
                case 4:
                    HandleTask4();
                    break;
                case 5:
                    HandleTask5();
                    break;
                case 6:
                    HandleTask6();
                    break;
                default:
                    Console.WriteLine("Неправильний вибір завдання");
                    break;
            }
        }

        static void HandleTask1()
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 13, 21 };
            PrintFilteredNumbers(array);
        }

        static void PrintFilteredNumbers(int[] array)
        {
            int[] evenNumbers = ArrayOperations.FilterArray(array, ArrayOperations.IsEven);
            Console.WriteLine("Парні числа: " + string.Join(", ", evenNumbers));

            int[] oddNumbers = ArrayOperations.FilterArray(array, ArrayOperations.IsOdd);
            Console.WriteLine("Непарні числа: " + string.Join(", ", oddNumbers));

            int[] primeNumbers = ArrayOperations.FilterArray(array, ArrayOperations.IsPrime);
            Console.WriteLine("Прості числа: " + string.Join(", ", primeNumbers));

            int[] fibonacciNumbers = ArrayOperations.FilterArray(array, ArrayOperations.IsFibonacci);
            Console.WriteLine("Числа Фібоначчі: " + string.Join(", ", fibonacciNumbers));
        }

        static void HandleTask2()
        {
            Action showTime = Task2.ShowCurrentTime;
            Action showDate = Task2.ShowCurrentDate;
            Action showDayOfWeek = Task2.ShowCurrentDayOfWeek;

            showTime();
            showDate();
            showDayOfWeek();

            double triangleBase = 3.0;
            double triangleHeight = 4.0;
            Predicate<double> isValidSide = Task2.AreSidesValid;

            if (isValidSide(triangleBase) && isValidSide(triangleHeight))
            {
                Func<double, double, double> calcTriangleArea = Task2.CalculateTriangleArea;
                Console.WriteLine($"Площа трикутника: {calcTriangleArea(triangleBase, triangleHeight)}");
            }
            else
            {
                Console.WriteLine("Невалідні сторони для трикутника.");
            }

            Func<double, double, double> rectangleArea = Task2.CalculateRectangleArea;
            double areaOfRectangle = rectangleArea(10, 5);
            Console.WriteLine($"Площа прямокутника: {areaOfRectangle}");
        }

        static void HandleTask3()
        {
            string text = "Hello world, learn programming";
            string wordToFind = "world";
            Task.Task3(text, wordToFind);
        }

        static void HandleTask4()
        {
            var numbers = new[] { 14, 28, 3, 21, 8, 35, 6, 49 };
            int count = Task.Task4(numbers);
            Console.WriteLine($"Кількість чисел, кратних семи: {count}");
        }

        static void HandleTask5()
        {
            var number = new[] { -5, 3, 0, 7, -2, 10, -1, 5 };
            int counter = Task.Task5(number);
            Console.WriteLine($"Кількість позитивних чисел: {counter}");
        }

        static void HandleTask6()
        {
            var num = new[] { -5, 3, 0, 7, -2, 10, -1, 5 };
            Task.Task6(num);
        }
    }
}

