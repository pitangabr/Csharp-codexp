using System;

namespace Rodizio_Veícular
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Rodizio Veícular");

            Console.WriteLine ("Digite o final da Placa");
            // int placa = int.Parse(Console.ReadLine());
            string placa = Console.ReadLine();

            int caracteres = placa.Length;

            int final = int.Parse (placa.Substring(caracteres - 1));

            //Processamento

            Console.WriteLine($"A posição 0 é: {final}");

            if(final == 0 || final == 1){
                Console.WriteLine ("O dia da semana: Segunda-Feira");
            } else if (final == 2 || final == 3){
                Console.WriteLine ("O dia da semana: Terça-Feira ");
            } else if(final == 4 || final == 5){
                 Console.WriteLine ("O dia da semana: Quarta-Feira ");
            } else if(final == 6 || final == 7){
                 Console.WriteLine ("O dia da semana: Quinta-Feira ");
            } else if(final == 8 || final == 9){
                 Console.WriteLine ("O dia da semana: Sexta-Feira");
            } else {
                    Console.WriteLine("Insira apenas o último dígito");
            }
        }
    }
}
