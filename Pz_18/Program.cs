using System;

namespace Pz_18
{
    class Program
    {
        static void GetString(char r) //void - если ничего не возв
        {
            Console.WriteLine(new String(r, 10)); //rrrrrrrrrrr
        }
        static void Main(string[] args)
        {
            GetString('u');
        }

    }
}
