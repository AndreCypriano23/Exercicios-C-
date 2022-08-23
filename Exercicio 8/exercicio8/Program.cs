using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidadeMedia, distanciaPercorrida, litrosUsados;

            Console.WriteLine("Digite o tempo gasto na viagem: ");
            tempo = int.Parse(Console.ReadLine());
      
            Console.WriteLine("Digite a velocidade média na viagem: ");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempo * velocidadeMedia;

            litrosUsados = distanciaPercorrida / 12;

            Console.WriteLine("A velocidade média é: " + velocidadeMedia);
            Console.WriteLine("O tempo gasto na viagem é de " + tempo);
            Console.WriteLine("A distância percorrida na viagem é de: " + distanciaPercorrida);
            Console.WriteLine("A quantidade de litros usadas é de: " + litrosUsados);           

        }
    }
}
