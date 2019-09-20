using System;

namespace Cargos_com_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cargos com Switch");

            Console.WriteLine("Digite o número do cargo para descobrir seu salário");
            Console.WriteLine("------------------");
            Console.WriteLine("(1) - Diretor");
            Console.WriteLine("(2) - Gerente");
            Console.WriteLine("(3) - Professor");
            Console.WriteLine("(4) - Coodernador");
            Console.WriteLine("(5) - Atendente");
            Console.WriteLine("------------------");

            string resposta = Console.ReadLine();
            switch(resposta){
                case "1":
                Console.WriteLine("O Salário de Diretor é de R$18.000,00");
                break;
                case "2":
                Console.WriteLine("O Salário de Gerente é de R$12.000,00");
                break;
                case "3":
                Console.WriteLine("O Salário de Professor é de R$1.000,00");
                break;
                case "4":
                Console.WriteLine("O Salário de Coodernador é de R$9.000,00");
                break;
                case "5":
                Console.WriteLine("O Salário de Atendente é de R$1.500,00");
                break;
                
            }
        }
    }
}
