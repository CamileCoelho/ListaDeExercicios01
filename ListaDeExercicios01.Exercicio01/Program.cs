using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace ListaDeExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Volume de uma caixa retangular. ");

            Console.WriteLine();

            decimal resultado = 0;

            Console.Write("Digite a altura da caixa(em metros). ");

            decimal altura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a largura da caixa(em metros). ");

            decimal largura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o comprimento da caixa(em metros). ");

            decimal comprimento = Convert.ToDecimal(Console.ReadLine());

            resultado = altura * largura * comprimento;

            Console.WriteLine("O resultado para o volume de sua caixa retangular, em metros cubicos, é: " + resultado);
            
        }
    }
}