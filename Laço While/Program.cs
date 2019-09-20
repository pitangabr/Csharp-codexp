using System;

namespace Laço_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de Repetição While");

            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine(contador);

                contador = contador + 1;
            } //fim do While.
        }
    }
}
