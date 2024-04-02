namespace EstruturasDeRepeticao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir a sequência de Fibonacci até um número informado.
           int valor1, valor2, valor3, contador;

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            valor1 = -1;
            valor2 = 1;
            contador = 0;

            while (contador < numero)
            {
                valor3 = valor1 + valor2;
                valor1 = valor2;
                valor2 = valor3;
                Console.Write(valor3 + " ");
                contador++;
            }
        }
    }
}
