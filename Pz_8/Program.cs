using System;
using System.Linq;

namespace Pz_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine(a.Sum());
            double proiz = 1;
            for (int i = 0; i < a.Length; i++)
            {
                proiz *= a[i];
            }
            Console.WriteLine(proiz);
        }
    }
}
