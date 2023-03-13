namespace ListaDeExercicios01.Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálculo do volume de uma esfera. ");

            Console.WriteLine();

            double raio;

            Console.Write("Digite o raio da esfera(em metros): ");

            Console.WriteLine();

            raio = Convert.ToDouble(Console.ReadLine());

            double volume = (4.0 / 3.0) * Math.PI * raio*raio*raio;

            Console.WriteLine("O volume da esfera, em metros cubisos, é: {0:F2}", volume);
        
        }
    }
}