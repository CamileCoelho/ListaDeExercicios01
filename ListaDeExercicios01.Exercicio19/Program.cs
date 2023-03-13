using System;

namespace ListaDeExercicios01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMC em adultos:");

            Console.WriteLine();

            decimal peso, altura, imc;

            Console.Write("Digite seu peso em kg: ");

            peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite sua altura em metros: ");

            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            imc = peso / ( altura * altura );

            if (imc < 18.5m)
            {
                Console.WriteLine("Sua condição é: Abaixo do peso.");
            }
            else if (imc >= 18.5m && imc < 25)
            {
                Console.WriteLine("Sua condição é: Peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sua condição é: Acima do peso.");
            }
            else
            {
                Console.WriteLine("Sua condição é: Obesidade.");
            }

        }
    }
}