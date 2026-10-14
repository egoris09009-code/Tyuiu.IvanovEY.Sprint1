using System;
using Tyuiu.IvanovEY.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
            Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            int result = ds.DistanceBetweenDots(x1, y1, x2, y2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Расстояние между точками = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}