using System;

namespace exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento=0, salarioNovo=0;

            Console.WriteLine("PROGRAMA DE CÁLCULO SALARIAL DE FUNCIONÁRIO: ");

            Console.WriteLine("Digite o salário: ");      
            salario = int.Parse(Console.ReadLine());
            
            if(salario >= 1500 && salario <= 1750){
                aumento = (salario * 0.12);
            }else if(salario < 2000){
                aumento = (salario * 0.10);
            }else if(salario < 3000){
                aumento = (salario * 0.07);
            }else{
                aumento = (salario * 0.05);
            }


             salarioNovo = salario + aumento; 
             Console.WriteLine("O salário atual é: " + salarioNovo);
        }
    }
}
