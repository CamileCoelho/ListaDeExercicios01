using System;

namespace ListaDeExercicios01.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Volume de uma lata de óleo");

            Console.WriteLine();

            decimal raio, altura, volume, numPI;

            Console.Write("Digite o raio da lata de óleo,em metros,(o raio é a metade do diâmetro da lata): ");

            Console.WriteLine();

            raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura da lata de óleo(em metros): ");

            Console.WriteLine();

            altura = Convert.ToDecimal(Console.ReadLine());

            numPI = 3.14159265358979323846m;

            volume = numPI * raio*raio * altura;

            Console.WriteLine("O volume da lata de óleo, em metros cubicos, é: {0:F2}", volume);

        }
    }
}