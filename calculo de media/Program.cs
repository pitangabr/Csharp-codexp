using System;

namespace calculo_de_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma de três numeros");
            int n1;
            int n2;
            int n3;

            Console.WriteLine ("Digite o Primeiro Número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o Segundo Número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o Terceiro Número");
            n3 = int.Parse(Console.ReadLine());

            // int resultado = (n1+n2+n3)/3;
            // Console.WriteLine($"O resultado é: {resultado}");

            float soma = (n1+n2+n3);
            float media = soma/3;

            Console.WriteLine ($"A media é de: {media}");
        }
    }
}
