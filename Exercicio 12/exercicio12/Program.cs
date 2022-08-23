using System;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Digite um número:");
            number = int.Parse(Console.ReadLine());
            
           if(number <= 10){
               Console.WriteLine("F1");
           }else if(number > 10 && number <= 100){
               Console.WriteLine("F2");
           }else{
               Console.WriteLine("F3");
           }
            
        }
    }
}
