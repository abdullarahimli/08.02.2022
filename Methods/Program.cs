using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci ededi daxil edin: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2 ci ededi daxil edin: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("3 cu ededi daxil edin: ");
            int c = int.Parse(Console.ReadLine());

            int[] arr = { a, b, c };


            FindLargeNumber(a, b, c);
        }
        static void FindLargeNumber(int a, int b, int c)
        {
            int[] arr = { a, b, c };

            if (a > b && a > c)
            {
                Console.WriteLine($"En boyuk eded, {a}");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"En boyuk eded, {b}");
            }
            else
            {
                Console.WriteLine($"En boyuk eded, {c}");
            }

        }
    }
}
