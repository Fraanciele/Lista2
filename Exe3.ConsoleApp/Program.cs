using System;

namespace Exe3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Peso;
            string Altura;

            Console.WriteLine("Número 3 da lista 2");

            Console.WriteLine("Por favor, informe o peso");
            string Peso = Convert.ToDouble(Peso);
            double Peso = Convert.ToDouble(Peso);

            Console.WriteLine("Por favor, informe a altura");
            string Altura= Console.ReadLine();
            double Altura = Convert.ToDouble(Altura);

            double imc = Peso / (Altura, 2);

            if (imc < 18.5)
                Console.WriteLine("Você esta abaixo do peso");

            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("Você está com seu peso normal, Parabéns");

            else if (imc > 25 && imc < 30)
                Console.WriteLine("Você está com seu peso normal, Parabéns");

            else if (imc > 30)
                Console.WriteLine("Obeso");

        }
    }
}
