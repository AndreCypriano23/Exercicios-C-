using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double horasTrabalhadas, valorHora, percentualDesconto, salarioBruto,
            totalDesconto, salarioLiquido;

            Console.WriteLine("Digite as horas trabalhadas no mês: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            valorHora = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o percentual de desconto: ");
            percentualDesconto = int.Parse(Console.ReadLine());

            
            Console.WriteLine("As horas trabalhadas no mês são: " + horasTrabalhadas);
            
            Console.WriteLine("O valor da hora trabalhada no mês é: " + valorHora);
          
            Console.WriteLine("O porcentual de desconto é: " + percentualDesconto);

            salarioBruto = horasTrabalhadas * valorHora;

            Console.WriteLine("O salário bruto é: " + salarioBruto);

            totalDesconto = (percentualDesconto/100) * salarioBruto;

            Console.WriteLine("O total de desconto é: " + totalDesconto);

            salarioLiquido = salarioBruto - totalDesconto;

            Console.WriteLine("O salário líquido é: " + salarioLiquido);

        }
    }
}
