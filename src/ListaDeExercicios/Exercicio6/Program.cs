namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular a área de um terreno retangular.

            Console.Write("Digite o Comprimento do terreno: ");
            double comprimentoDoTerreno = double.Parse(Console.ReadLine());
            

            Console.Write("Digite a Largura do terreno: ");
            double larguraDoTerreno = double.Parse(Console.ReadLine());

            double area = comprimentoDoTerreno * larguraDoTerreno;

            Console.WriteLine($"A área do terreno é {area} metros quadrados.");
        }
    }
}
