namespace ListaDeExercicios01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Converter a temperatura de graus Fahrenheit para graus Celsius.");

            Console.WriteLine();

            Console.Write("Digite a temperatura em graus Fahrenheit: ");

            Console.WriteLine();

            double tempFahrenheit = Convert.ToDouble(Console.ReadLine());

            double tempCelsius = (tempFahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: {0:F2} ", tempCelsius); // para arredondar p duas casas decimais ao ler a resposta

        }
    }
}