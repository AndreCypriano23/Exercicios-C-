using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {         
            int num1, num2;

            Console.WriteLine("Exercício 1: Digite dois numeros para descobrir a soma");
            Console.WriteLine("Digite o primeiro número:");        
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos dois números é: " + (num1 + num2));

        }
    }
}
