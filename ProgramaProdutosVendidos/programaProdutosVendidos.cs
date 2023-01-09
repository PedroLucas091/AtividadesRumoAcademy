using System;

namespace LucroProduto
{
    class programaProdutosVendidos
    {
        static void Main(string[] args)
        {
            string nomeProduto;
            int quantidade;
            double precoCompra, precoVenda, lucroTotal = 0;
            do
            {
                Console.Write("Insira o nome do produto (ou digite 'sair' para encerrar): ");
                nomeProduto = Console.ReadLine();

                if (nomeProduto.ToLower() != "sair")
                {
                    Console.Write("Insira a quantidade vendida: ");
                    quantidade = int.Parse(Console.ReadLine());
                    Console.Write("Insira o preço de compra do produto: ");
                    precoCompra = double.Parse(Console.ReadLine());
                    Console.Write("Insira o preço de venda do produto: ");
                    precoVenda = double.Parse(Console.ReadLine());
                    double lucro = (precoVenda - precoCompra) * quantidade;
                    lucroTotal += lucro;
                    Console.WriteLine("O lucro do produto " + nomeProduto + " é " + lucro );
                }
            } while (nomeProduto.ToLower() != "sair");

            Console.WriteLine("O lucro total é: " + lucroTotal);
        }
    }
}