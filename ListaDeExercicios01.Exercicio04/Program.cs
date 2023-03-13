namespace ListaDeExercicios01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálculo do consumo de combustível por km.");

            Console.WriteLine();

            double kmInicial, kmFinal, consumoCombustivel;

            Console.Write("Digite o km inicial: ");

            Console.WriteLine();

            kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o km final: ");

            Console.WriteLine();

            kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo de combustível em litros: ");

            Console.WriteLine();

            consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distancia = kmFinal - kmInicial;

            double consumoPorKm = consumoCombustivel / distancia;

            Console.WriteLine("O consumo de combustível, em litros, por km foi de: {0:F2}", consumoPorKm);
            
        }

    }
}
