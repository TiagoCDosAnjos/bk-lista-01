using System;

namespace EstruturaDeDecisao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Identificar se um número é par ou ímpar.

            Console.Write("Digite um nímero: ");
            int numero = int.Parse(Console.ReadLine());

             if (numero % 2 == 0)
                Console.WriteLine($"O numero {numero} é: Par");

             else
                Console.WriteLine($"O numero {numero} é: Impar");
        }
    }
}
