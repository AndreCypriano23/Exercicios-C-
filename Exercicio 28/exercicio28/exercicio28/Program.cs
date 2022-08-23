using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio28
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            String[] nomes = null;
            nomes = new String[4];

            double[] salarios = null;
            salarios = new double[4];

            for(int i=0; i < nomes.Length ; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + " funcionário");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Digite o salário do" + (i + 1) + " funcionário");
                salarios[i] =  Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine((i+1) + " Funcionário é: " + nomes[i]);

            }

            /*Console.WriteLine("Valores printados");
            for (int i = 0; i < valores.Length; i++)
            {             
                Console.WriteLine(valores[i]);
            }

            Console.WriteLine("Valores negativos digitados: ");
            for (int i = 0; i < valores.Length; i++)
            {   
                if (valores[i] < 0)
                {
                    Console.WriteLine(valores[i]);
                }
            }

            Console.WriteLine("Soma dos valores positivos");
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] >= 0)
                {
                    aux += valores[i];
                }
            }

            Console.WriteLine(aux);*/

            Console.ReadKey();
        }
    }
}
