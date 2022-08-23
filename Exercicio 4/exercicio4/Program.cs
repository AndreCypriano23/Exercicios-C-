using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendas, salarioFinal;

            Console.WriteLine("Exercício 4:");
            Console.WriteLine("Digite o nome do vendedor:");        
            nome = Console.ReadLine();
            Console.WriteLine("Digite o salário fixo do vendedor: ");
            salarioFixo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu total de vendas no mês em dinheiro ");
            totalVendas = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do vendedor: " + nome);
            Console.WriteLine("Salário Fixo: " + salarioFixo);

            salarioFinal = salarioFixo + (totalVendas * 0.10);

            Console.WriteLine("O salário final é de: " + salarioFinal);

        }
    }
}
