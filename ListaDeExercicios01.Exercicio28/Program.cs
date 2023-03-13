namespace ListaDeExercicios01.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa que imprime os números de 1 a 100 em ordem crescente, substituindo os números\r\nmúltiplos de 3 pela palavra &quot;Fizz&quot; e os múltiplos de 5 pela palavra &quot;Buzz&quot;. Para números que são múltiplos de\r\nambos, use &quot;FizzBuzz&quot;.");

            Console.WriteLine();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(Convert.ToString(i) + " ");
                }

            }

        }
    }
}