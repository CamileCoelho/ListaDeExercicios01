namespace ListaDeExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Algoritimo que efetua a soma de todos os números ímpares que são múltiplos de três e que se\r\nencontram no conjunto dos números de 1 até 500.");

            Console.WriteLine();

            Console.WriteLine();

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2  != 0 && i % 3 == 0)
                {

                    soma = soma + i;

                }
            }

            Console.WriteLine("O resultado da soma de todos os valores impares e multiplos de três entre 1 e 500 é:" + soma);

        }
    }
}