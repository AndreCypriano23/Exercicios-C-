using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Exercício 1: Digite dois numeros para descobrir a soma, divisão, multiplicação e divisão:");
            Console.WriteLine("Digite o primeiro número:");        
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos dois números é: " + (num1 + num2));
            Console.WriteLine("A multiplicação dos dois números é: " + (num1 * num2));
            Console.WriteLine("A subtração dos dois números é: " + (num1 - num2));
           

            if(num2 <= 0 )
            {
                Console.WriteLine("Não é possível dividir número por 0");
            }else
            {
                Console.WriteLine("A Divisão dos dois números é: " + (num1 / num2));
            }
        }
    }
}
