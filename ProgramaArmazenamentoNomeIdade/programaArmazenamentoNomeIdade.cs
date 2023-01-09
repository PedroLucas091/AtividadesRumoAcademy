using System;
using System.Collections.Generic;

namespace ProgramaArmazenamentoNomeIdade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Informe o nome da " + i + "ª pessoa:");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe a idade da " + i + "ª pessoa:");
                int idade = int.Parse(Console.ReadLine());
                pessoas.Add(new Pessoa(nome, idade));
            }
            Pessoa maisVelho = pessoas[0];
            foreach (Pessoa p in pessoas)
            {
                if (p.Idade > maisVelho.Idade)
                {
                    maisVelho = p;
                }
            }
            Console.WriteLine("A pessoa mais velha é " + maisVelho.Nome + ", com " + maisVelho.Idade + " anos.");
        }
    }

    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}