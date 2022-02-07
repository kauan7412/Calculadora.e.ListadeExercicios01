using System;

namespace padaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite quantos pães foram vendidos");
            double paes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite quantos broas foram vendidas");
            double broas = Convert.ToDouble(Console.ReadLine());
            double paesx = paes / 0.12;
            double broasx = broas / 1.50;
            double resultado = paesx + broasx;
            double poupança = resultado * 0.1;
            Console.WriteLine($"No expediente de hoje, foram vendidos {paes} pães e {broas} broas dando um resultado de {resultado} reais, descontando {poupança} reais para a poupança");
        }
    }
}
