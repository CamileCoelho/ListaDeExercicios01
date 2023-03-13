namespace ListaDeExercicios01.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Verificando se um número é primo ou não.");

            Console.WriteLine();

            int numero, i, contagem = 0;

            Console.Write("Digite um número inteiro e positivo: ");

            numero = Convert.ToInt32(Console.ReadLine());   

            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contagem++;
                }
            }

            if (contagem == 2)
            {
                Console.WriteLine("{0} é um número primo.", numero);
            }
            else
            {
                Console.WriteLine("{0} não é um número primo.", numero);
            }

        }
    }
}