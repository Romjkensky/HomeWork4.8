using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._8_1
{
    internal class Pract1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Случайная матрица и сумма ее элементов");
            Console.WriteLine("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int [row, col];
            Random rnd = new Random();

            Console.WriteLine("Ваша матрица: ");

            int sum = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write($"{matrix[i, j],1} ");
                }
                Console.WriteLine();
            }

            for (int i = 0;i < col; i++)
            {
                for(int j = 0;j < row; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine($"Сумма всех элементов в матрице = {sum}");
        }
    }
}
