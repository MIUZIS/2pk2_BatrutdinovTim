
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] f_nums = new double[5, 10];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                double sum = 0;
                double work = 1;
                for (int j = 0; j < 10; j++)
                {
                    f_nums[i, j] = rnd.NextDouble();
                    //Вычисление произведения и суммы элементов строки
                    sum += f_nums[i, j];
                    work *= f_nums[i, j];

                    Console.Write(f_nums[i, j] + "  ");
                }

                Console.WriteLine();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Сумма строки №" + i + " = " + sum);
                Console.WriteLine("Произведение строки №" + i + " = " + work);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
