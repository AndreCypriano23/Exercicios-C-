using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio32
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0 , num2 = 0 , num3 = 0 , num4 = 0, media = 0, maior = 0, menor = 0;

            Console.WriteLine("Programa para receber números e informar: média, maior e menor");
            Console.WriteLine("Digite o primeiro número");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Você não digitou um número inteiro.");         
            }


            Console.WriteLine("Digite o segundo número");
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Você não digitou um número inteiro.");
                return;
            }


            Console.WriteLine("Digite o terceiro número");
            try
            {
                num3 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Você não digitou um número inteiro.");
            }



            Console.WriteLine("Digite o quarto número");
            try
            {
                num4 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Você não digitou um número inteiro. Que pena Programa Encerrando...");
            }



            media = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("A média  dos  números é: " + media);



            if(num1 > num2 && num1 > num3 && num1 > num4)
            {
                maior = num1;
                Console.WriteLine("O maior número é " + num1);
            }
            else if(num2 > num1 && num2 > num3 && num2 > num4)
            {
                maior = num2;
                Console.WriteLine("O maior número é " + num2);
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                maior = num3;
                Console.WriteLine("O maior número é " + num3);
            }
            else
            {
                maior = num4;
                Console.WriteLine("O maior número é " + num4);
            }



            if (num1 < num2 && num1 < num3 && num1 < num4)
            {
                menor = num1;
                Console.WriteLine("O menor número é " + num1);
            }
            else if (num2 < num1 && num2 < num3 && num2 > num4)
            {
                menor = num2;
                Console.WriteLine("O menor número é " + num2);
            }
            else if (num3 < num1 && num3 < num2 && num3 < num4)
            {
                menor = num3;
                Console.WriteLine("O menor número é " + num3);
            }
            else
            {
                maior = num4;
                Console.WriteLine("O maior número é " + num4);
            }



            Console.ReadKey();

        }
    }
}
