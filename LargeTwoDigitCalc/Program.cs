using System;

namespace LargeTwoDigitCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ci qiymeti daxil edin: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("2 ci qiymeti daxil edin: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("3 ci qiymeti daxil edin: ");
            double c = double.Parse(Console.ReadLine());

            LargeTwoDigitCalc(a, b, c);
        }
        static void LargeTwoDigitCalc(double a, double b, double c)
        {
            double[] arr = { a, b, c };
            double sum = 0;

            if (a > b && a > c && b > c)
            {
                sum = a + b;
                Console.WriteLine(sum);
            }
            else if (b > a && c > a)
            {
                sum = b + c;
                Console.WriteLine(sum);
            }
            else if (a > b && c > b)
            {
                sum = a + c;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Ala bilmediniz");
            }
        }
    }
}
