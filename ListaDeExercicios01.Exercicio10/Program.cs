namespace ListaDeExercicios01.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Cálculo da média ponderada de duas notas de um Aluno.");

            Console.WriteLine();

            decimal primeiraNota, segundaNota, mediaPonderada, pesoPrimeiraNota, pesoSegundaNota;

            //const decimal pesoPrimeiraNota = 20m, pesoSegundaNota = 80m; - isso seria se eu fosse determinar o peso para cada prova

            Console.Write("Digite a nota que tirou na primeira prova: ");

            primeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");

            pesoPrimeiraNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a nota que tirou na segunda prova: ");

            segundaNota = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");

            pesoSegundaNota = Convert.ToDecimal(Console.ReadLine());

            mediaPonderada = ((primeiraNota * pesoPrimeiraNota) + (segundaNota * pesoSegundaNota)) / (pesoPrimeiraNota + pesoSegundaNota);

            Console.WriteLine("A média harmônica é: {0:F2} ", mediaPonderada);
        }
    }
}