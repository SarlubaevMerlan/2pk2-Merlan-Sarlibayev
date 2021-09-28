using System;

namespace Merlan
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 задание
            for (int i = -100; i <= 0; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //2 задание
            char a = 'к';
            for (int i = 0; i < 8; i++)
            {
                Console.Write(a++);
            }
            Console.WriteLine();
            Console.WriteLine();

            //3 задание
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("####");
            }
            Console.WriteLine();

            //4 задание
            for (int i = 0; i < 100; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            //5 задание
            for (int i = 0, j = 55; i - j != 11; i++, j--)
            {
                Console.WriteLine(i + " " + j);
            }

        }
    }
}
