using System;

namespace exercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            double num =  0;
            Console.WriteLine("Digite um número real:");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma opcão do menu para realizar: ");
            Console.WriteLine("1 - Raiz Quadrada");
            Console.WriteLine("2 - Metdade");
            Console.WriteLine("3 - 10% do número");
            Console.WriteLine("4 - dobro");
    
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case (1):

                    num = Math.Sqrt(num);
                    Console.WriteLine("A raiz quadrada do número é: " + num);

                    break;

               case(2): 

                    Console.WriteLine("O dobro do número é: " + num/2);

                    break;

                case(3):
                    
                    num = (num * 0.10);

                     Console.WriteLine("10% desse número é: " + num + "%");

                    break;
                
                case(4):

                    num += num;

                    Console.WriteLine("O dobro desse número é: " + num);

                    break;
            }

            Console.ReadKey();
        }
    }
}
