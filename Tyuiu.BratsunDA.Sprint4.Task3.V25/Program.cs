using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BratsunDA.Sprint4.Task3.V25.Lib;

namespace Tyuiu.BratsunDA.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 7, 3, 5, 3, 6 }, { 4, 6, 2, 5, 7 }, { 2, 3, 3, 3, 5 }, { 2, 7, 7, 6, 2 }, { 6, 6, 4, 3, 6 } };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #4| Выполнил: Брацун Д.А. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил Брацун Д.А. | ПКТБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая считает произведение 4 столбца массива.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }



            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Произведение 4 столбца массива = " + result);
            Console.ReadKey();
        }
    }
}
