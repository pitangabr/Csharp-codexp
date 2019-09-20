using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rodizio Veícular");

            Console.WriteLine ("Digite o final da Placa");
            int placa = int.Parse(Console.ReadLine());

            //Processamento

            if(placa == 0 || placa == 1){
                Console.WriteLine ("O dia da semana: Segunda-Feira");
            } else if (placa == 2 || placa == 3){
                Console.WriteLine ("O dia da semana: Terça-Feira ");
            } else if(placa == 4 || placa == 5){
                 Console.WriteLine ("O dia da semana: Quarta-Feira ");
            } else if(placa == 6 || placa == 7){
                 Console.WriteLine ("O dia da semana: Quinta-Feira ");
            } else {
                 Console.WriteLine ("O dia da semana: Sexta-Feira");
            }
        }
    }
}
