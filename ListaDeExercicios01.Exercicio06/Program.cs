namespace ListaDeExercicios01.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Converter a temperatura de graus Celcius para graus Fahrenheit.");

            Console.WriteLine();

            Console.Write("Digite a temperatura em graus Celcius: ");

            Console.WriteLine();

            double tempCelsius = Convert.ToDouble(Console.ReadLine());

            double tempFahrenheit = (tempCelsius * 1.8) + 32 ;

            Console.WriteLine("A temperatura em graus Fahrenheit é: {0:F2} ", tempFahrenheit);

        }
    }
}