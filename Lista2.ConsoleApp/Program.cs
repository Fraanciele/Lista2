//Exercício 1:
//• Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
//soma de A + B é menor que C

using System;

namespace Lista2.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string A, B, C;

            {

                Console.WriteLine("Digite o valor A");
                string A = Console.ReadLine();
                double a = Convert.ToDouble(A)

                Console.WriteLine("Digite o valor B");
                string B = Console.ReadLine();
                double b = Convert.ToDouble(B)

                Console.WriteLine("Digite o valor C");
                string C = Console.ReadLine();
                double c = Convert.ToDouble(C)

                if (a + b < c)
                    Console.WriteLine("A + B é menor que C" );

                else
                    Console.WriteLine("A + B é menor que C");


            }
}
