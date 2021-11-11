using System;

namespace Pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToUpper();
            string[] array = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach(string i in array)
            {
                if (i[0] == 'С') count++;
            }
            Console.WriteLine(count);
        }
    }
}
