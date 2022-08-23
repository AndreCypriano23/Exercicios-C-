using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[50];
            double[] salario = new double[50];
            char continua = 's';
            double soma = 0;
            double maior = 0;
            double menor = 0;
            double media = 0;
            int i = 0;

            while(continua == 's')
            {
                i++;
                Console.WriteLine("Digite o Nome do " +  i + " funcionário");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite o salário do " + i + " funcionário");
                salario[i] = Convert.ToDouble(Console.ReadLine());

                //Console.WriteLine(nome[i]);

                soma += salario[i];

                if(salario[i] > salario[i - 1])
                {               
                    maior = salario[i];
                    //menor = salario[i];
                }
         

                if (salario[i - 1] < salario[i] && salario[i - 1] > 0)
                {
                    menor = salario[i - 1];
                }  

                media = soma / i;

                Console.WriteLine("Deseja continuar? S/N");
                continua = Convert.ToChar(Console.ReadLine().ToLower());
            }

            Console.WriteLine("A soma dos salários é de: " + soma);
            Console.WriteLine("O maior salário é : " + maior);
            Console.WriteLine("O menor salário é : " + menor);
            Console.WriteLine("A media dos salários é de : " + media);

            Console.ReadKey();
        }
    }
}
