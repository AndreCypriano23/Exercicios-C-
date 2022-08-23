using System;

namespace exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");      
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número: ");      
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2){
                Console.WriteLine("Os dois números dão iguais!");
            }else{
                 Console.WriteLine("Os dois números são diferentes!");
                 if(num1 > num2){
                     Console.WriteLine("Número 1: " + num1 + " (MAIOR) ");
                     Console.WriteLine("Número 2: " + num2 + " (MENOR) ");
                 }else{
                     Console.WriteLine("Número 2: " + num2 + " (MAIOR) ");
                     Console.WriteLine("Número 1: " + num1 + " (MENOR) ");
                 }
            }

        }
    }
}
