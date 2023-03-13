namespace ListaDeExercicios01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do salário total de um vendedor.");

            Console.WriteLine();

            decimal salarioBase, totalVendas, comissao, salarioTotal;

            Console.Write("Informe o salário base: ");

            Console.WriteLine();

            salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o total de vendas: ");

            Console.WriteLine();

            totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a comissão (em %): ");

            Console.WriteLine();

            comissao = Convert.ToDecimal(Console.ReadLine()) / 100;

            salarioTotal = salarioBase + totalVendas * comissao;

            Console.WriteLine("Salário total: R$ " + salarioTotal.ToString("F2"));
        }
    }
}