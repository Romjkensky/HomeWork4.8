using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._8_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Сложение матриц");
            Console.WriteLine("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[row, col];
            int[,] matrixB = new int[row, col];
            int[,] matrixC = new int[row,col];

            Random rnd = new Random();

            Console.WriteLine("Первая матрица: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixA[i, j] = rnd.Next(10);
                    Console.Write($"{matrixA[i, j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица: ");
            for(int i = 0;i < row; i++)
            {
                for(int j = 0;j < col; j++)
                {
                    matrixB[i, j] = rnd.Next(10);
                    Console.Write($"{matrixB[i,j],3}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма матриц: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixC[i,j] = matrixA[i, j] + matrixB[i,j];
                    Console.Write($"{matrixC[i,j],3}");
                }
                Console.WriteLine();
            }

        }
    }
}
