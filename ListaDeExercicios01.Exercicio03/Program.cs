namespace ListaDeExercicios01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Volume de um Cilindro");

            Console.WriteLine(); 

            decimal raio, altura, volume, numPI;

            Console.Write("Digite o raio do cilindro(em metros): ");

            Console.WriteLine();

            raio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a altura do cilindro(em metros): ");

            Console.WriteLine();

            altura = Convert.ToDecimal(Console.ReadLine());

            numPI = 3.14159265358979323846m;

            volume = numPI * raio*raio * altura;

            Console.WriteLine("O volume do cilindro, em metros cubicos, é: {0:F2}", volume);

        }
    }
}