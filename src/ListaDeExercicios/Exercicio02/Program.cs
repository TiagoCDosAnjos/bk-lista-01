namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius
             */
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em Celsius é " +  celsius + "°C");

        }
    }
}
