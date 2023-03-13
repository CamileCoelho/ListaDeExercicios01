namespace ListaDeExercicios01.Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Algoritimo para ler dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso\r\ncontrário multiplique A por B.");

            Console.WriteLine();

            decimal valorA, valorB, respostaSoma, respostaMultiplicacao;

            Console.Write("Digite um valor para A: ");

            valorA = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite um valor para B: ");

            valorB = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            respostaSoma = valorA + valorB;

            respostaMultiplicacao = valorA * valorB;

            if (valorA == valorB)
            {
                Console.Write("A soma do valor A + valor B é o valor C: " + respostaSoma);
            }
            else
            {
                Console.Write("A multiplicação do valor A * valor B é o valor C: " + respostaMultiplicacao);
            }
        }
    }
}