using System;
using System.Linq;

namespace Pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            char[] lst = new char[9];
            char[] max = new char[9];



            char[][] array = new char[9][];

            for (int i = 0; i < 9; i++)
            {

                array[i] = new char[rnd.Next(6, 40)];

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToChar(rnd.Next(100));
                }
            }

            Console.WriteLine("Вывод основного массива");
            for (int i2 = 0; i2 < array.Length; i2++)
            {
                char[] item = array[i2];
                for (int i1 = 0; i1 < item.Length; i1++)
                {
                    char i = item[i1];
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                lst[i] = array[i][array[i].Length - 1];
            }

            Console.WriteLine("Вывод последних элементов");
            foreach (char i in lst)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                max[i] = array[i].Max();
            }

            Console.WriteLine("Вывод максимальных элементов");
            foreach (char i in max)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {

                var t = array[i][0];
                char p = max[i];
                int l = Array.IndexOf(array[i], p);
                array[i][0] = array[i][l];
                array[i][l] = t;
            }

            Console.WriteLine("Вывод основного массива с измененными местами элементами");
            foreach (char[] item in array)
            {
                foreach (char i in item)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
