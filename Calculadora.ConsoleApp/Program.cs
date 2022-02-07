using System;

namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("calculadora top 1.4");
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("digite 2 para subtrair");
                Console.WriteLine("digite 3 para multiplicar");
                Console.WriteLine("digite 4 para dividir");
                Console.WriteLine("digite s para sair");
                opcao = Console.ReadLine();
                if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "s")
                {
                    if (opcao == "s")
                        break;
                    Console.Write("digite o primeiro número");
                    double primeironumero = Convert.ToDouble(Console.ReadLine());
                    Console.Write("digite o segundo número");
                    double segundonumero = Convert.ToDouble(Console.ReadLine());
                    double resultado = 0;
                    if (opcao == "1")
                    {
                        resultado = primeironumero + segundonumero;
                    }
                    else if (opcao == "2")
                    {
                        resultado = primeironumero - segundonumero;
                    }
                    else if (opcao == "3")
                    {
                        resultado = primeironumero * segundonumero;
                    }
                    else if (opcao == "4")
                    {
                        if (primeironumero == 0 || segundonumero == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("esta operação não pode ser realisada enquanto 0 estiver presente");
                            Console.ResetColor();
                            Console.ReadLine();
                            continue;
                        }
                        else
                        resultado = primeironumero / segundonumero;
                    }
                    Console.WriteLine(resultado);
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("esta tecla não se encontra no menu, digite novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                }
                
            }
            while (opcao != "s");
        }
    }
}
