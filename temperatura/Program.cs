using System;

namespace temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite quantos graus em celcios está.");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"A temperatura neste momento em fahrenheit está {fahrenheit}f. ");
        }
    }
}
