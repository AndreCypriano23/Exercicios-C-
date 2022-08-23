using System;

namespace exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            double altura1, peso1, altura2, peso2;



            Console.WriteLine("Digite o nome da primeira pessoa");
            nome1 = Console.ReadLine();
            
            Console.WriteLine("Digite a altura da primeira pessoa");
            altura1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o peso da primeira pessoa");
            peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa");
            nome2 = Console.ReadLine();
            
            Console.WriteLine("Digite a altura da segunda pessoa");
            altura2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite o peso da segunda pessoa");
            peso2 = Convert.ToDouble(Console.ReadLine());


           if(altura1 > altura2)
            {
                Console.WriteLine(nome1 + "É a pessoa mais alta");
            }
            else
            {
                 Console.WriteLine(nome2 + " É a pessoa mais alta");
            }

           if(peso1 > peso2)
            {
                Console.WriteLine(nome1 + " É a pessoa mais pesada");
            }
            else
            {
                 Console.WriteLine(nome2 + " É a pessoa mais pesada");
            }


           
        }
    }
}
