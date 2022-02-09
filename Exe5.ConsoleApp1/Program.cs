//Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.


using System;

namespace Exe5.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5 lista 2");

            Console.Write("Por favor, digite o valor A");
            string ValorA = Console.ReadLine();
            int valorA = Convert.ToInt32(ValorA);

            Console.Write("Por favor, digite o valor B");
            string ValorB = Console.ReadLine();
            int valorB = Convert.ToInt32(ValorB);

            int ValorC;

            if
                (valorA == valorB)
                ValorC = valorA + valorB;

            else
                ValorC = valorA * valorB;

            Console.WriteLine("O valor de C é" +ValorC);


        }
    }
}
