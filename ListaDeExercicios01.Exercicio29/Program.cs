namespace ListaDeExercicios01.Exercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10. Para isso, o programa deve gerar\r\ntodas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.\r\nDesafio: Para cada número, tente separar em colunas.");

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,3} ", i * j); // utiliza {0,3} para formatar em colunas de 3 caracteres
                }
                Console.WriteLine(); // pula para a próxima linha após a última coluna
            }

        }
    }
}