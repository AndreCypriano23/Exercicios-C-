using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 85, soma = 0;

            while(num < 100)
            {
                num++;
                if(num % 2 == 0)
                {
                    soma += num;
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("Soma dos números pares" + soma);

            Console.ReadKey();
        }
    }
}
