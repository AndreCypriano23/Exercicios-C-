using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Digite uma temperatura em graus Celsus: ");
            C = int.Parse(Console.ReadLine());
            
            F =  (9 * C + 160) / 5 ;

            Console.WriteLine("A temperatura convertida em Fahrenheit é: " + F);
            
        }
    }
}
