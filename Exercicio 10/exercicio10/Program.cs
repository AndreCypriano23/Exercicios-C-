using System;

namespace exercicio10
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
        
            if(number1 > number2 && number1 > number3){
                Console.WriteLine("O maior número que você digitou é o primeiro: " + number1);
            }else if(number2 > number1 && number2 > number3){
                Console.WriteLine("O maior número que você digitou é o segundo: " + number2);
            }else if(number3 > number1 && number3 > number2){
                Console.WriteLine("O maior número que você digitou é o terceiro: " + number3);
            }else{
                Console.WriteLine("Os três números são iguais, portanto nenhum deles é maior que o outro");
            }

        }
    }
}
