namespace salarioTotalVendedor
{
    internal class programaSalarioVendedor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
                string nome = Console.ReadLine();

            Console.WriteLine( nome + ", informe o seu salário fixo: ");
                string salarioFixoinforma = Console.ReadLine();

            Console.WriteLine("Informe quantas vendas você fez este mês: ");
                string totalVendasMesInforma = Console.ReadLine();

                    //Ler uma string que representa um número decimal//
                decimal salarioFixo = decimal.Parse(salarioFixoinforma);
                decimal totalVendasMes = decimal.Parse(totalVendasMesInforma);
                                
                    //Calculos//
                decimal salarioFinal = salarioFixo + (totalVendasMes * 0.15m);

            Console.WriteLine( nome + ", o seu salário neste mês será de R$" + salarioFinal + " reais. ");

        }
    }
}