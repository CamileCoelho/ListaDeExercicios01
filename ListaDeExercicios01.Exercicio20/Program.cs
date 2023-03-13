namespace ListaDeExercicios01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("Verificar se um numero é ímpar ou par.");

            Console.WriteLine();

            decimal numero;

            Console.WriteLine("Digite um número: ");

            Console.WriteLine();

            numero = Convert.ToDecimal(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

        }
    }
}