using System;

namespace controleDeCombustivel
{
    class programaCalculoDistancia
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***PROGRAMA PARA CONTROLE DE COMBUSTÍVEL***");
            Console.WriteLine("***PARA MELHOR ATENDIMENTO, INICIE O PROGRAMA SOMENTE APÓS COMPLETAR O TANQUE***" );
                
            Console.Write("\nInsira a capacidade maxima do tanque do seu veiculo\n ");
                double capacidadeTanque = double.Parse(Console.ReadLine());

            Console.Write("Insira a quantidade de combustível consumido em litros:\n ");
                double combustivelLitros = double.Parse(Console.ReadLine());

            Console.Write("Insira a distância percorrida em quilômetros:\n ");
                double distanciaQuilometros = double.Parse(Console.ReadLine());

                            //CalculoValoresRecebidos//
                   double resultadoConsumo = (distanciaQuilometros / combustivelLitros);
                   double resultadoDistancia = (capacidadeTanque * resultadoConsumo);
            
                            //AredondarValores//
                   double consumoArredondado = Math.Round(resultadoConsumo, 1);
                   double distanciaArredondada = Math.Round(resultadoDistancia, 1);
    
            Console.WriteLine("O seu consumo foi de " + consumoArredondado + " quilômetros por litro.");
            Console.WriteLine("Com o tanque cheio, o seu veiculo tem uma autonomia total de  " + distanciaArredondada + " quilômetros! ");
        }
    }
}
