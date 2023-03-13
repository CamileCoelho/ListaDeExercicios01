namespace ListaDeExercicios01.Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("Cálculo da média harmônica das notas de um Aluno.");

            Console.WriteLine();

            int qtdDeNotas;

            decimal somaInversaDasNotas = 0;

            Console.Write("Digite a quantidade de notas: ");

            qtdDeNotas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtdDeNotas; i++)
            {
                Console.Write("Digite a nota {0}: ", i);

                decimal nota = Convert.ToDecimal(Console.ReadLine());

                somaInversaDasNotas += 1 / nota;
            }

            decimal mediaHarmonica = qtdDeNotas / somaInversaDasNotas;

            Console.WriteLine("A média harmônica é: {0:F2} ", mediaHarmonica);

        }
    }
}