using System;

namespace exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
           int idade;
           char opcao = 's';

            
            do{
                Console.WriteLine("--------- Categorias de Atletas ----------");
            
                Console.WriteLine("Digite a idade do atleta para saber a categoria: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if(idade <= 0){
                    Console.WriteLine("Digite uma idade maior do que zero.");
                }
                else if(idade > 0 && idade < 5){
                    Console.WriteLine("SEM CATEGORIA");
                }else if(idade <= 10){
                    Console.WriteLine("INFANTIL");
                }else if(idade <= 15){
                    Console.WriteLine("JUVENIL");
                }else if(idade <= 20){
                    Console.WriteLine("JUNIOR");
                }else{
                    Console.WriteLine("PROFISSIONAL");
                }

                Console.WriteLine("Deseja Continuar? (DIGITE 's' para continuar ou qualquer outra tecla para encerrar");
                opcao = Convert.ToChar(Console.ReadLine());

            }while(opcao == 's' );
            

        }
    }
}
