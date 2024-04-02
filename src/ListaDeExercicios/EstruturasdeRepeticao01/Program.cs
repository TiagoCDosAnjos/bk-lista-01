namespace EstruturasdeRepeticao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gerar e escrever os números ímpares entre 100 e 200
            int numero = 100;
            do
            {
                if(numero % 2 != 00)
                    Console.WriteLine(numero);

                numero++;

            } while (numero <= 200);


        }
    }
}
