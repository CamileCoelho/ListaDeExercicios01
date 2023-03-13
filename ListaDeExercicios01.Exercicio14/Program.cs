namespace ListaDeExercicios01.Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.\r\nConsidere sempre anos completos, e que um ano possui 365 dias.");

            Console.WriteLine();

            Console.WriteLine("Digite seu nome: ");

            string nome ;
            
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite sua idade: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine($"{nome}, você já viveu {diasDeVida} dias.");
        }
    }
}