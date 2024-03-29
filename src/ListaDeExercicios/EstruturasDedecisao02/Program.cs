namespace EstruturasDedecisao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ordenar três valores inteiros e diferentes em ordem decrescente.

            Console.Write("Digite 0 primeiro valor: ");
            int primeiro = int.Parse(Console.ReadLine());

            Console.Write("Digite 0 segundo valor: ");
            int segundo = int.Parse(Console.ReadLine());

            Console.Write("Digite 0 terceiro valor: ");
            int terceiro = int.Parse(Console.ReadLine());

            int maior, segundoMaior, terceiroMaior;

            if ( primeiro > segundo & primeiro > terceiro)
                maior = primeiro;

            else if ( segundo > terceiro)
                maior = segundo;
            else
                maior = terceiro;

            if (  )

            Console.WriteLine("0 maior valor é: " + maior);


        }
    }
}
