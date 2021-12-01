using System;
using System.IO;

namespace Pz_17
{
    class Program
    {
        static float IMT(float m,float height)
        {
            return m / height / 100 * height / 100;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите свою массу: ");
            float m = float.Parse(Console.ReadLine());
            Console.Write("Введите свой рост: ");
            float hight = float.Parse(Console.ReadLine());
            Console.Write("Ваш индекс массы: " + IMT(m, hight));
        }
    }
}
