using System;

namespace SumDigitsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin: ");
            int a = int.Parse(Console.ReadLine());

            SumDigitsNumber(a);
        }
        static void SumDigitsNumber(int a)
        {
            int[] arr = { a };
            int count = 0;

            while (a > 0)
            {
                int b = a % 10;
                a = a / 10;
                count = count + b;
            }
            Console.WriteLine(count);


        }
    }
}
