namespace ListaDeExercicios01.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Algoritimo para ler um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu\r\nresultado.");

            Console.WriteLine();

            Console.Write("Digite um valor inicial A: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int fatorial = 1;

            Console.Write($"{a}! = ");

            for (int i = 1; i <= a; i++)
            {

                fatorial = fatorial * i; //ou fatorial *= i;

                if (i == a)
                {
                    Console.Write($"{i} = {fatorial}");
                }
                else
                {
                    Console.Write($"{i} x ");
                }

            }
        }
    }
}