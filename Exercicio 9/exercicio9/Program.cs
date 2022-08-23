using System;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());

            if(numero > 10){
                Console.WriteLine("O número que você digitou é maior do que 10!");
            }


        }
    }
}
