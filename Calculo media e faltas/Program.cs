using System;

namespace Calculo_media_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APP Cáculo de Média e Faltas");
            Console.WriteLine("Bem Vindo A Escola SENAI de Informática");

            Console.WriteLine("Digite a primeira nota");
            int nota1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int nota2 = int.Parse (Console.ReadLine());

            Console.WriteLine("Digite sua quantidaded de faltas");
            int faltas = int.Parse (Console.ReadLine());

            //Processamentos 

            double media = (nota1+nota2)/2;

            if(media>=50 && faltas<=30){
                Console.WriteLine("Parabéns você foi Aprovado");
            }else{
                Console.WriteLine("Parabéns você foi Reprovado, seu Inutil");
            }
        }
    }
}
