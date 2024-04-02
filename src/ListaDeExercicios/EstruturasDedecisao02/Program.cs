namespace EstruturasDedecisao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ordenar três valores inteiros e diferentes em ordem decrescente.

            Console.Write("Digite 0 primeiro valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite 0 segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite 0 terceiro valor: ");
            int n3 = int.Parse(Console.ReadLine());

            int maior = 0, segundoMaior = 0, terceiroMaior = 0;

            if (n1 >= n2 & n1 >= n3)
            {
                maior = n1;

                if (n2 >= n3)
                {
                    segundoMaior = n2;
                    terceiroMaior = n3;
                }
                else
                {
                    segundoMaior = n3;
                    terceiroMaior = n2;
                }
            }
            else if (n2 >= n1 & n2 >= n3)
            {
                maior = n2;

                if (n3 >= n1)
                {
                    segundoMaior = n3;
                    terceiroMaior = n1;
                }
                else
                {
                    segundoMaior = n1;
                    terceiroMaior = n3;
                }
            }
            else
            {
                maior = n3;
                if (n2 >= n1)
                {
                    segundoMaior = n2;
                    terceiroMaior = n1;
                }
                else
                {
                    segundoMaior = n1;
                    terceiroMaior = n2;
                }
            }

            Console.WriteLine($"Os números em ordem decrescente são: {maior} , {segundoMaior} , {terceiroMaior}");
        }
    }
}
