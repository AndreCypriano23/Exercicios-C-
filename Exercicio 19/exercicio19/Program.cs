using System;

namespace exercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float diaria=60.00f, valorAcrescimo=0, valorFinal=0;
            int dias=0;

            //diaria = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas diárias você vai ficar no hotel: (valor da diária é de R$ 60,00 +  a TAXA DE SERVIÇO) ");   
            dias = int.Parse(Console.ReadLine());
            //Console.WriteLine("A diária é de: " + diaria);
            diaria = diaria * dias;

            if(dias > 15){
                valorAcrescimo = dias * 5.50f;
            }else if(dias == 15){
                valorAcrescimo = dias * 6.00f;              
            }else{
                valorAcrescimo = dias * 8.00f;
            }

            valorFinal = diaria + valorAcrescimo;

            Console.WriteLine("Valor diarias: " + diaria);
            Console.WriteLine("Valor total das taxas de serviços: " + valorAcrescimo);
            Console.WriteLine("Valor total: " + valorFinal);

        }
    }
}
