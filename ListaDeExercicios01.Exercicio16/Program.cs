namespace ListaDeExercicios01.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de\r\nimpostos.");

            Console.WriteLine();

            double salarioInicial, salarioComAumento, salarioFinal;

            Console.Write("Digite seu salario atual: ");

            Console.WriteLine();

            salarioInicial = Convert.ToInt32(Console.ReadLine());

            salarioComAumento = salarioInicial * 1.15;

            salarioFinal = salarioComAumento * 0.92;

            Console.WriteLine("O seu salario inicial era de R${0:F2} ", salarioInicial);

            Console.WriteLine();

            Console.WriteLine("O seu salario bruto com 15% de aumento é R${0:F2} ", salarioComAumento );

            Console.WriteLine(); 
            
            Console.WriteLine("O seu salario final com o desconto dos impostos de 8% é de R${0:F2} ", salarioFinal);

            Console.WriteLine();

        }
    }
}