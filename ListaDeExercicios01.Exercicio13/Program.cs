namespace ListaDeExercicios01.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada\r\npãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a\r\nvenda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).\r\nVocê foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as\r\nquantidades de pães e de broas, e depois calcular os dados solicitados. ");

            Console.WriteLine();

            int qtdPaes, qtdBroas;

            double valorDosPaes, valorDasBroas, valorTotal, valorPoupanca;

            Console.Write("Digite a quantidade de pães vendidos: ");

            qtdPaes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite a quantidade de broas vendidas: ");

            Console.WriteLine();

            qtdBroas = Convert.ToInt32(Console.ReadLine());

            valorDosPaes = qtdPaes * 0.12;

            valorDasBroas = qtdBroas * 1.5;

            valorTotal = valorDosPaes + valorDasBroas;
            valorPoupanca = valorTotal * 0.1;

            Console.WriteLine("O total arrecadado foi de R$ {0:0.00}.", valorTotal);

            Console.WriteLine();

            Console.WriteLine("O valor a ser guardado na poupança é de R$ {0:0.00}.", valorPoupanca);

        }
    }
}