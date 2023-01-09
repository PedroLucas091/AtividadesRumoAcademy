using System;

namespace ConsumoDeCombustivel
{
    class programaConsumoCombustivel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n***PROGRAMA PARA CONTROLE DE CONSUMO DE COMBUSTIVEL***\n\n");

            Console.Write("Insira a distância percorrida em quilômetros:\n");
            double distanciaQuilometros = double.Parse(Console.ReadLine());

            Console.Write("Insira o volume de combustível consumido em litros:\n");
            double combustivelLitros = double.Parse(Console.ReadLine());

            double consumo = distanciaQuilometros / combustivelLitros;
            double consumoArredondado = Math.Round(consumo, 1);

            Console.WriteLine("\nO seu consumo foi de " + consumoArredondado + " litros por quilômetro.\n");
        }
    }
}
