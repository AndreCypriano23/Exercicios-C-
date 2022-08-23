using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, resultado = 0;

            Console.WriteLine("Digite um número: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Digite um número inteiro! Programa encerrando..");
            }
      

            while(resultado < num)
            {
                resultado++;
                Console.WriteLine(resultado);
            }

            Console.ReadKey();

        }
    }
}
