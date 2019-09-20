using System;

namespace Aumento_de_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aumento de Salário");

            Console.WriteLine ("Digite seu Salario:");
            float salario = float.Parse (Console.ReadLine());

            if(salario < 990){
                double reajuste = salario * 0.3;
                double reajustado = salario + reajuste;
                Console.WriteLine ($"Seu salário reajustado fica: {reajustado}");
            }else{
                Console.WriteLine($"Você não possui direito ao aumento de salário");
            }
        }
    }
}
