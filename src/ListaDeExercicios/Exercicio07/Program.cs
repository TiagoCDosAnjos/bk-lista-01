namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verificar se a soma de A + B é menor que C.

            Console.Write("Digite o valor de A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            double c = double.Parse(Console.ReadLine());

            double menor;

            if ((a + b) < c)
                Console.WriteLine($"A= {a} + B = {b} é menor que C = {c}");
            else
                Console.WriteLine($"A= {a} + B = {b} não é menor que C = {c}");
        }
    }
}
