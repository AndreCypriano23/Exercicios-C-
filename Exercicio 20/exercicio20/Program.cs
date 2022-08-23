using System;

namespace exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Double portugues, matematica, ciencias;

            Console.WriteLine("Digite as três notas da prova na sequência para saber o resultado: ");
            
            Console.WriteLine("Digite a nota de Português: ");
            portugues = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota de Matemática: ");
            matematica = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota de Ciências: ");
            ciencias = Convert.ToDouble(Console.ReadLine());

            Double media = (portugues + matematica + ciencias) / 3;

            if(media >= 7){
                Console.WriteLine("Parabéns, você foi aprovado!");
            }else if(media >= 4){
                Console.WriteLine("Prova Final");
            }else{
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine("media: " + media);
        
            Console.ReadKey();
        }
    }
}
