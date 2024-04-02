namespace EstruturasDeRepeticao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.

            int numero = 1;

            while (numero <= 100)
            {
                if (numero % 3 == 0)
                    Console.Write(" Fizz, ");
                else if (numero % 5 == 0)
                    Console.Write(" Buzz, ");
                else
                    Console.Write(numero + ", ");
                numero++;
            }
        }
    }
}
