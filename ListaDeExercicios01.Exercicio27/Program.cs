namespace ListaDeExercicios01.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê um número e imprime a sequência de Fibonacci até esse número.");

            Console.Write("Digite um número: ");

            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.Write("Sequência de Fibonacci até {0}: {1} {2}", n, a, b);
            while (c <= n)
            {
                c = a + b;
                if (c <= n)
                {
                    Console.Write(" {0}", c);
                }
                a = b;
                b = c;
            }
        }
    }
}