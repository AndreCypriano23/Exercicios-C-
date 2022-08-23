using System;

namespace exercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Digite o primeiro número: ");    
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");    
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2){
                Console.WriteLine("O primeiro número: " + num1 + " é maior que o segundo");
            }else{       
                Console.WriteLine("O segundo número: " + num2 + " é maior que o primeiro");
            }




        }
    }
}
