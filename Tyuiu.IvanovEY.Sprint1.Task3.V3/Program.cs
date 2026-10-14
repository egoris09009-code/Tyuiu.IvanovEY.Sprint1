using System;
using Tyuiu.IvanovEY.Sprint1.Task3.V3.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину (см): ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ширину (см): ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту (см): ");
            double height = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            double result = ds.ParallelepipedVolume(length, width, height);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Объем: " + result + " см.куб.");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}