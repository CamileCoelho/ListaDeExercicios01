namespace ListaDeExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Algoritmo para ler um valor para uma variável N de 1 a 10 e calcular a tabuada de N.");

            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Digite o numero de 1 a 10 que deseja gerar a tabuada:  ");

            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (numero >= 1 && numero <= 10)
            {
                for (int i = 1; i <= 10; i = i + 1)
                {

                    int resultadoMultiplicacao = i * numero;

                    Console.WriteLine(+ numero + "  x  " + i + "  =  " + resultadoMultiplicacao);

                }
            }
            else
            {
                Console.WriteLine("Valor inválido para N!");
            }

        }
    }
}