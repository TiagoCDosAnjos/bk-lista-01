namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o salário total de um vendedor.

            Console.Write("Digite o salário base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas: ");
            double totalDeVendas = double.Parse(Console.ReadLine());

            double comissao = 0.05;

            double salarioTotal = salarioBase + (totalDeVendas * comissao);

            Console.WriteLine($"O salário total do vendedor é R$ {salarioTotal}");
        }
    }
}
