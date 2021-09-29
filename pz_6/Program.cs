using System;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            t = 0;
            while (t < 10)
            {
                Console.Write(t * t);
                Console.Write(" - ");
                Console.WriteLine(t * t * t);
                t = t + 1;
            }
        }
    }
}
