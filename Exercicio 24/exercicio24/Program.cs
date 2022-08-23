using System;

namespace exercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            double venda;
            int opcao = 0;

            Console.WriteLine("Digite o valor da venda");
            venda = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("1 - Venda a Vista - desconto de 10%");
            Console.WriteLine("2 - Venda a Prazo 30 dias - desconto de 5% ");
            Console.WriteLine("3 - Venda a Prazo 60 dias - mesmo preço ");
            Console.WriteLine("4 - Venda a Prazo 90 dias - acréscimo de 5%");
            Console.WriteLine("5 - Venda com cartão de débito - desconto de 8% Venda ");
            Console.WriteLine("6 - com cartão de crédito - desconto de 7%");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    venda = venda - (venda * 0.10);
                    Console.WriteLine("Valor da venda é: " + venda);

                    break;

                    
                case 2:               
                    venda = venda - (venda * 0.05);
                    Console.WriteLine("Valor da venda é: " + venda);

                    break;
                case 3:
                     Console.WriteLine("Valor da venda é: " + venda);

                    break;               
                    
                case 4:
                    venda = venda + (venda * 0.05);
                    Console.WriteLine("Valor da venda é: " + venda);

                    break;
                    
                case 5:                
                    venda = venda - (venda * 0.08);
                    Console.WriteLine("Valor da venda é: " + venda);

                     break;
                    
                case 6:
                    venda = venda - (venda * 0.07);
                    Console.WriteLine("Valor da venda é: " + venda);

                    break;
            }

        }
    }
}
