using System;

namespace Pz_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(". ");
            for(int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Length < str[i + 1].Length)
                {
                    (str[i], str[i + 1]) = (str[i + 1], str[i]);
                }
            }
            Console.WriteLine(string.Join(". ", str));
        }
    }
}
