namespace ListaDeExercicios01.Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Algoritmo para gerar e escrever os números ímpares entre 100 e 200.");

            Console.WriteLine();

            for (int i = 100; i <= 200; i ++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}