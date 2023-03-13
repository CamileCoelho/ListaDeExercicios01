namespace ListaDeExercicios01.Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo que le três valores inteiros diferentes e mostre-os em ordem decrescente.");

            Console.WriteLine();

            int primeiroValor, segundoValor, terceiroValor;

            Console.Write("Digite um valor para A: ");

            primeiroValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite um valor para B: ");

            segundoValor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Digite um valor para C: ");

            terceiroValor = Convert.ToInt32(Console.ReadLine());


            if (primeiroValor >= segundoValor && primeiroValor >= terceiroValor)
                {
                    if (segundoValor >= terceiroValor)
                    {
                        Console.WriteLine($"{primeiroValor}, {segundoValor}, {terceiroValor}");
                    }
                    else
                    {
                        Console.WriteLine($"{primeiroValor}, {terceiroValor}, {segundoValor}");
                    }
                }
                else if (segundoValor >= primeiroValor && segundoValor >= terceiroValor)
                {
                    if (primeiroValor >= terceiroValor)
                    {
                        Console.WriteLine($"{segundoValor}, {primeiroValor}, {terceiroValor}");
                    }
                    else
                    {
                        Console.WriteLine($"{segundoValor}, {terceiroValor}, {primeiroValor}");
                    }
                }
                else
                {
                    if (primeiroValor >= segundoValor)
                    {
                        Console.WriteLine($"{terceiroValor}, {primeiroValor}, {segundoValor}");
                    }
                    else
                    {
                        Console.WriteLine($"{terceiroValor}, {segundoValor}, {primeiroValor}");
                    }
                }

                Console.ReadKey();

            }

        }

    }
