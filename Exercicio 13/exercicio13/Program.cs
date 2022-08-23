using System;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Digite um número:");
            number = int.Parse(Console.ReadLine());
            
           if(number > 100 && number < 200){
               Console.WriteLine("O número está no intervalo entre 100 e 200");
           }
           
        }         
        
    }
}
