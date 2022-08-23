using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            int leia = 0;


            Console.WriteLine("Digite o número para ver a tabuada dele");
            leia = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {             
                Console.WriteLine(leia + " X " + i + " = " + (leia * i));           
            }

            Console.ReadKey();
        }
    }
}
