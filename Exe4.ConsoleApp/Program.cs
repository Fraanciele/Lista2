// 4:
//• Faça um algoritmo para receber um número qualquer e informar na tela se
//é par ou ímpar



using System;

namespace Exe4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Numero;
            int numero;

            Console.WriteLine("Exercicio 4");

            Console.Write("Digite um número");
            string Numero = Console.ReadLine();
            int numero = Convert.ToInt32(Numero);

            if (numero % == 0)
                Console.WriteLine("O número é par");

            else
                Console.WriteLine("O número é impar");

        }
    }
}
