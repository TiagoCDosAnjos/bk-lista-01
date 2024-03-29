using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a média ponderada de duas provas realizadas por um aluno

            Console.Write("Digite a 1 nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a 2 nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double pesoNota1 = 0.4;
            double pesoNota2 = 0.6;

            double mediaPonderada = (nota1 * pesoNota1) + (nota2 * pesoNota2);

            Console.WriteLine("A média ponderada do aluno é " + mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
