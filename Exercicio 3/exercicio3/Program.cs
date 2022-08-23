using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome, sobrenome;

            Console.WriteLine("Exercício 3: ");
            Console.WriteLine("Digite o seu primeiro nome:");        
            nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            sobrenome =  Console.ReadLine();
            Console.WriteLine("O seu nome completo é: " + nome + " " + sobrenome);
        }
    }
}
