namespace ListaDeExercicios01.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Algoritmo para ler\r\numa temperatura Celsius e imprima em Fahrenheit .");

            Console.WriteLine();

            Console.Write("Digite a temperatura em graus Celcius: ");

            Console.WriteLine();

            decimal tempCelsius = Convert.ToDecimal(Console.ReadLine());

            decimal tempFahrenheit = (tempCelsius * 1.8m) + 32;

            Console.WriteLine("A temperatura em graus Fahrenheit é: {0:F2} ", tempFahrenheit);
        }
    }
}