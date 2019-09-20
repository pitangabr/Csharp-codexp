using System;

namespace Calculo_de_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("APP Calculo de Idade");
            Console.WriteLine("Qual Categoria você se encaixa");

            Console.WriteLine("Digite sua Idade");
            int idade = int.Parse (Console.ReadLine());

            //Processamentos

            if(idade<=18 && idade >=60){
                Console.WriteLine("Meia");
            }else{
                Console.WriteLine("Inteira");
            }
        }
    }
}
