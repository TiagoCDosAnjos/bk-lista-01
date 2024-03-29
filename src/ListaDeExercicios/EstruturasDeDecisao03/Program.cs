namespace EstruturasDeDecisao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.

            Console.Write("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("abaixo do peso");
            else if (imc >= 18.6 & imc <= 24.9)
                Console.WriteLine("Peso Ideal");
            else if (imc >= 25.0 & imc <= 29.9)
                Console.WriteLine("Levemente acima do peso");
            else
                Console.WriteLine("Obesidade");

        }
    }
}
