namespace ListaDeExercicios01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("Algoritmo para ler os valores A, B, C e imprimir na tela se a soma de A + B é menor que C.");

            Console.WriteLine();

            decimal valorA, valorB, valorC;

            Console.WriteLine("Digite um valor para A: ");

            valorA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");

            valorB = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite um valor para C: ");

            valorC = Convert.ToDecimal(Console.ReadLine());

            if ( (valorA + valorB) <  valorC)
            {
                Console.WriteLine("A soma vo valor A + valor B é menor que o valor de C.");
            }
            else
            {
                Console.WriteLine("A soma vo valor A + valor B não é menor que o valor de C.");
            }

        }
    }
}