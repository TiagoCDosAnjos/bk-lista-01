namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            Console.Write("Digite a altura da caixa retangular: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite a largura da caixa retangular: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento da caixa retangular: ");
            double complimento = double.Parse(Console.ReadLine());

            double resultado = altura * largura * complimento;

            Console.WriteLine($"O volume da caixa é {resultado} unidades cúbicas");

        }
    }
}
