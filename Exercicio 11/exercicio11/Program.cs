using System;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Digite o primeiro número:");
            number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número:");
            number2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o terceiro número:");
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números que você digitou são: " + number1 + " " + number2 + " " + number3);

            if(number1 + number2 < number3){
                Console.WriteLine("A soma dos dois primeiros números é menor do que o terceiro número.");
            }else if(number1 + number2 > number3){
                 Console.WriteLine("A soma dos dois primeiros números é maior do que o terceiro número.");
            }else{
                 Console.WriteLine("A soma dos dois primeiros números é igual ao terceiro número.");
            }
        }
    }
}
