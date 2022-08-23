using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1, num2 = 0, aux= 0;

            Console.WriteLine("Sequência Fibonacci aparecendo na sua tela");

            Console.WriteLine(0);
            for (int i = 0; i < 20; i++)
            {
               
                num2 = aux;
                aux = num1 + num2;
                num1 = num2;

                //Console.WriteLine("num1: " + num1);
                //Console.WriteLine("num2: " + num2);
                Console.WriteLine(aux);
            }

            Console.ReadKey();

        }
    }
}
