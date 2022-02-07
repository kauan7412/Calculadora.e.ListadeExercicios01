using System;

namespace imobiliaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a altura x do estabelecimento");
            double alturax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite a altura y do estabelecimento");
            double alturay = Convert.ToDouble(Console.ReadLine());
            double area = alturax * alturay;
            Console.WriteLine($"a area do estabelecimento é de {area}cm²");
        }
    }
}
