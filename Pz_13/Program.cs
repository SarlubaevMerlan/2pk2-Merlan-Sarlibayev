using System;

namespace Pz_13
{
    class Program
    {
        [Flags()]
        public enum Values
        {
            Verybad = 1,
            Unsatisfactory = 2,
            Satisfactorily = 3,
            Good = 4,
            Great = 5,
        }

        public static void Main(string[] args)
        {
            Console.Write("Введите оценку по пяти бальной шкале: ");

            int a = int.Parse(Console.ReadLine());
            Console.Write("Ты поработал: ");
            switch (a)
            {
                case (int)Values.Verybad:
                    Console.WriteLine("Очень плохо");
                    break;

                case (int)Values.Unsatisfactory:
                    Console.WriteLine("Неудовлетворительно");
                    break;

                case (int)Values.Satisfactorily:
                    Console.WriteLine("Удовлитварительно");
                    break;

                case (int)Values.Good:
                    Console.WriteLine("Хорошо");
                    break;

                case (int)Values.Great:
                    Console.WriteLine("Отлично");
                    break;
            }
        }
    }
}
