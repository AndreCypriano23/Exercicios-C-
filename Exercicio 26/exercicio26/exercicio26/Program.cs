using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, numUser = 0;
            int opcao = 0;

            do
            {

                Console.WriteLine("Digite um número");
                numUser = Convert.ToInt32(Console.ReadLine());

                while (num < numUser)
                {
                    num++;
                    Console.WriteLine(num);
                }

                num = 0;
                Console.WriteLine("Digite 1 para digitar outro número ou digite qualquer outro numero para sair");
                opcao = Convert.ToInt32(Console.ReadLine());

            }while (opcao == 1);

            Console.WriteLine("Saindo......");

            Console.ReadKey();
        }
    }
}
