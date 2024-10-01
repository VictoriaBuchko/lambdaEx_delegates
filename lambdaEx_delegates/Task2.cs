using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaEx_delegates
{
    public class Task2
    {

        public static void ShowCurrentTime() => Console.WriteLine($"Поточний час: {DateTime.Now.ToString("HH:mm:ss")}");
        public static void ShowCurrentDate() => Console.WriteLine($"Поточна дата: {DateTime.Now.ToString("dd.MM.yyyy")}");
        public static void ShowCurrentDayOfWeek() => Console.WriteLine($"Поточний день тижня: {DateTime.Now.DayOfWeek}");
        public static double CalculateTriangleArea(double baseLength, double height) => 0.5 * baseLength * height;
        public static double CalculateRectangleArea(double width, double height) => width * height;

        //Я додала метод для перевірки чи є сторони більшими за 0( тут як раз я використаю придекат, мені здається для інших завдань
        //він трохи не підходить так як там потрібно повертати значення)
        public static bool AreSidesValid(double side) => side > 0;
    }
}
