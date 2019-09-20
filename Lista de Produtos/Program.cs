using System;

namespace Lista_de_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Lista de Compras");

            string [] compras = new string[6]; // [] identifica que um vetor
            int contador = 0;

            while (contador <= 5)
            {
                Console.WriteLine($"Digite o {contador+1} produtos");
                compras [contador] = Console.ReadLine ();
                contador++;
            }
            contador = 0;
            while(contador <= 5){
                Console.WriteLine($"O Produtos na posição {contador + 1} é {compras[contador]}");
                contador++;
            }


        }
    }
}
