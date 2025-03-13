using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int l = 10, c = 10;
            int[,] array = new int[l, c];
            Random rand = new Random();

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            Console.Write("Введите номер элемента 5 строки , который будет заменен на — 1949: ");
            int column = Convert.ToInt32(Console.ReadLine());
            array[4, column - 1] = 1949;

            for (int i = 0; i < c; i++)
            {

                Console.Write(array[4, i] + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Введите номер стори: ");
            int line = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("\nВведите номер столбца: ");
            int columnn = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("\nВведите число на которое будет заменен элемент массива: ");
            int num = Convert.ToInt32(Console.ReadLine());
            array[line, columnn] = num;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
