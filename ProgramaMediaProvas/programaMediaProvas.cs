using System;
using System.Collections.Generic;

namespace ProgramaMediaProvas
{
    internal class programaMediaProvas
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Seja bem vindo, " + nome + "!");

            List<double> numbers = new List<double>();
            Console.WriteLine("\nDigite as notas das provas!");
            Console.WriteLine("Após inserir todas, confirme digitando: s \n");

            while (true)
            {
                Console.WriteLine("Digite a nota: ");
                string inicioNota = Console.ReadLine();
                if (inicioNota.ToLower() == "s")
                {
                    break;
                }
                double notasProvas = double.Parse(inicioNota);
                numbers.Add(notasProvas);
            }

            double soma = 0;
            foreach (double notasProvas in numbers)
            {
                soma += notasProvas;
            }

            int todasNotas = numbers.Count;
            double mediaNotas = soma / todasNotas;

                
             double mediaArredondada =  Math.Round(mediaNotas, 1);
            Console.WriteLine( nome +", a média é " + mediaArredondada + " !");

        }
    }
}