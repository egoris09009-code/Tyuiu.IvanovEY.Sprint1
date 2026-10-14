using System;
using Tyuiu.IvanovEY.Sprint1.Task2.V27.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известна длина стороны квадрата. Вычислить периметр квадрата.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину стороны квадрата (целое число): ");
            int a = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            int result = ds.CalculateSquarePerimetr(a);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Периметр квадрата = " + result);
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}