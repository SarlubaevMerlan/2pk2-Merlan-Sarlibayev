using System;

namespace Pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            int[] result = new int[10];
            var random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result[i] = array[i, j];
                }
            }

            foreach (int a in result)
            {
                Console.WriteLine(a / 10);
            }
        }
    }
}
