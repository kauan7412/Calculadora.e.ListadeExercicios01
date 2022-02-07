using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite seu salario.");
            double salario = (Convert.ToDouble(Console.ReadLine()));
            double extra = (salario * 15) / 100;
            double salarioau = salario + extra;
            double impostos = (salarioau * 8) / 100;
            double salariomax = salarioau - impostos;
            Console.WriteLine($"Você recebera um aumento no seu salario no qual era {salario} reais, passou para {salarioau}, " +
                $"contando com mais o seu imposto de {impostos} reais, resultando em {salariomax} reais.");
        }
    }
}
