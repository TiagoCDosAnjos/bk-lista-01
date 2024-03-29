namespace EstruturaDeDecisao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar uma operação com base em dois valores inteiros A e B.

            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            double resultado = 0;

            Console.Write("Digite a operação: [ + ] , [ - ] , [ * ] ,  [ / ] : ");
            char operacao = char.Parse(Console.ReadLine());

            if (operacao == '+')
                resultado = a + b;
            else if (operacao == '-')
                resultado = a - b;
            else if (operacao == '*')
                resultado = a * b;
            else if (operacao == '/')
                resultado = a / b;
            else
                Console.WriteLine("opção invalida");

            Console.WriteLine("O resultado de " + a + " " + operacao + " " + b + " é: " + resultado);
        }
    }
}
