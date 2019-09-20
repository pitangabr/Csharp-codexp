using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Menu");
                        

            Console.WriteLine("Digite o primeiro numero");
            float numero1 = float.Parse (Console.ReadLine());
            
            Console.WriteLine ("Digite o segundo número");
            float numero2 = float.Parse (Console.ReadLine());

            Console.WriteLine("Digite a letra do cargo para saber se houve aumento");
            Console.WriteLine("(a) - Soma de dois números");
            Console.WriteLine("(b) - Subtração do Primeiro pelo Segundo");
            Console.WriteLine("(c) - Subtração do Segundo pelo Primeiro");
            Console.WriteLine("(d) - Multiplicação dos dois números");
            Console.WriteLine("(e) - Divisão do Primeiro pelo Segundo");
            Console.WriteLine("(f) - Divisão do Segundo pelo Primeiro");
   

            string resposta = Console.ReadLine();
            switch(resposta){
                case "a":
                    float soma = (numero1+numero2);
                    Console.WriteLine ($"A soma é de: {soma}");
                break;

                case "b":
                    float Subtração = (numero1-numero2);
                    Console.WriteLine ($"A Subtração é de: {Subtração}");
                break;

                case "c":
                    float subtração = (numero2-numero1);
                    Console.WriteLine ($"A subtração é de: {subtração}");
                break;

                case "d":
                    float Multiplicação = (numero1*numero2);
                    Console.WriteLine ($"A Multiplicação é de: {Multiplicação}");
                break;

                case "e":
                    float Divisão = (numero1/numero2);
                    Console.WriteLine ($"A Divisão é de: {Divisão}");
                break;

                case "f": 
                    float divisão = (numero2/numero1);
                    Console.WriteLine ($"A divisão é de: {divisão}");
                break;
            }
        }
    }
}
