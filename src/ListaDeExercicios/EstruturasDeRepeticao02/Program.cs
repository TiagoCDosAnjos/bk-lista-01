using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstruturasDeRepeticao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular o fatorial de um número e exibir o resultado.
           
            char continuar;
            int fatorial = 1;
            int numero = 0;
            
            Console.Write("Digite um número para calcular o fatorial: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 1) 
            {
                fatorial *= numero;
                numero--;
            }
            Console.WriteLine("Resultado: " + fatorial);
        }
    }
}
