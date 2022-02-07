using System;

namespace idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            int dias = idade * 365;
            Console.WriteLine($"{nome}, você já viveu {dias} dias.");
        }
    }
}
