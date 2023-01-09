namespace AlgoritimosNumPositivos
{
    internal class programaAlgoritimosNumPositivos
    {
        static void Main(string[] args)
        {
            int numPositivo = 0;
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Insira o " + i + "º número:");
                double numero = double.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    numPositivo++;
                    Console.WriteLine("Número positivo encontrado!");
                }
                
            }

            Console.WriteLine("O total de números positivos é de " + numPositivo + ".");

        }
    }
}