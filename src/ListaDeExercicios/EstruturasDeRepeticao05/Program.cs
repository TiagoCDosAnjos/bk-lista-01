
namespace EstruturasDeRepeticao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroTabuada = 1;
            while (numeroTabuada <= 10) 
            { 
                Tabuada(numeroTabuada);
                numeroTabuada++;
            } 
        }
        public static void Tabuada(int tabuada)
        {
            int numero = 1;
            while (numero <= 10)
            {
                int resultado = tabuada * numero;
                Console.WriteLine($"{tabuada} * {numero} = {resultado} ");
                numero++;
            }
            Console.WriteLine();
        }

    }
}

