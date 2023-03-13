using System;

namespace ListaDeExercicios01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.");

            Console.WriteLine();

            double largura, comprimento, area;

            Console.Write("Digite a largura do terreno (em metros): ");

            largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno (em metros): ");

            comprimento = Convert.ToDouble(Console.ReadLine());

            area = largura * comprimento;

            Console.WriteLine("A área do terreno é de {0:F2} metros quadrados.", area);

        }
    }
}