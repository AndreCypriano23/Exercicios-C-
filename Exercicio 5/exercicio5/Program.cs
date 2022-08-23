using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, media;

            Console.WriteLine("Exercício 5:");
            Console.WriteLine("Digite o nome do aluno:");        
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota da sua P1: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da sua P2: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da sua P3: ");
            nota3 = int.Parse(Console.ReadLine());
            
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média aritmética das notas do(a) " + nome + " é: " + media);

        }
    }
}
