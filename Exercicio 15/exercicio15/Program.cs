using System;

namespace exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string candidato;
            double matematica, portugues, conhecimentosGerais, media;

            Console.WriteLine("Digite o nome do candidato:");
            candidato = Console.ReadLine();
            Console.WriteLine("Digite a nota da primeira prova(Português): ");
            portugues = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova(Matemática): ");
            matematica = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da terceira prova(Conhecimentos Gerais): ");
            conhecimentosGerais = int.Parse(Console.ReadLine());

            media = (portugues + matematica + conhecimentosGerais) / 3;

            Console.WriteLine("--------------- DADOS DO CANDIDATO ---------------");
            Console.WriteLine("Nome do candidato:" + candidato);
            Console.WriteLine("Nota da prova de Português:" + portugues);
            Console.WriteLine("Nota da prova de Matemática:" + matematica);
            Console.WriteLine("Nota da prova de Conhecimentos Gerais:" + conhecimentosGerais);
            Console.WriteLine("Média Final" + media);

            if(media > 7 && portugues >= 5 && matematica >= 5 && conhecimentosGerais >= 5){
                Console.WriteLine("O aluno foi aprovado! Parabéns!!!!");
            }else{
                Console.WriteLine("O aluno foi reprovado.");
            }         

        }
    }
}
