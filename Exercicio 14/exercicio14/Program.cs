using System;

namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b, aux;

            Console.WriteLine("Digite um número A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número B:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("O número A é: " + a);
            Console.WriteLine("O número B é: " + b);

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Agora será apresentado os números com os valores trocados:");
            Console.WriteLine("O número A é: " + a);
            Console.WriteLine("O número B é: " + b);

        }
    }
}
