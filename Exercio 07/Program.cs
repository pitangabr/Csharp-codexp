using System;

namespace Exercio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercio 07");

            Console.WriteLine("Digite seu Salário:");
            float salario = float.Parse (Console.ReadLine());

            if (salario >= 1000){
                double comissao = salario * 0.5;
                double somado = salario + comissao;
                Console.WriteLine($"Seu salário com a soma da comissão fica em {somado}");
            }

        }
    }
}
