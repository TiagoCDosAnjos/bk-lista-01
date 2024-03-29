using System.Globalization;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
               Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
               Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros / km. */

            Console.Write("Digite a Quilometragem inicial: ");
            double QuilometragemInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quilometragem final: ");
            double QuilometragemFinal = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o Consumo de combustível: ");
            double ConsumoDeCombustivel = double.Parse(Console.ReadLine());

            double ConsumoPorKm = ConsumoDeCombustivel / (QuilometragemFinal - ConsumoDeCombustivel);

            Console.WriteLine($"O consumo de combustível por quilômetro é de " + ConsumoPorKm.ToString("F1",CultureInfo.InvariantCulture) + " litros/km.");

        }
    }
}
