using System;
using Tyuiu.IvanovEY.Sprint1.Task6.V18.Lib;

namespace Tyuiu.IvanovEY.Sprint1.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Иванов Е. Ю. | ИСТНб 26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Иванов Е. Ю. | ИСТНб 26-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* является символьным представлением натурального числа.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст: ");
            string value = Console.ReadLine();

            DataService ds = new DataService();
            bool result = ds.CheckNumber(value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (result)
            {
                Console.WriteLine("* Строка является натуральным числом.                                     *");
            }
            else
            {
                Console.WriteLine("* Строка НЕ является натуральным числом.                                  *");
            }

            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}