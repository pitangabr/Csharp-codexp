using System;

namespace Receba_mensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Receba sua Notificação"); // Faz com que a mensagem escrita a parece no TERMINAL;

            Console.WriteLine("Digite o primeiro número");
            float número1 = float.Parse(Console.ReadLine()); // Converte em linhas, permite a leitura;


            //Processamento

            if(número1 % 2 == 0){ // Diz quanto é o valor do resto (%), 
                                 //você dá um valor e ele é dividido por dois, caso tenha resto é Impar se não é Par. 
                                //EX: 2/2 = 1, não tem (Par); 7/2 = 3,5, há resto (Impar);

                Console.WriteLine ("Par"); //Diz se o numero é par;
            } else {
                Console.WriteLine ("Impar"); //Diz se o numero é par;
            } 
            Console.WriteLine("Digite o segundo número");// Diz quanto é o valor do resto (%), 
                                                        //você dá um valor e ele é dividido por dois, caso tenha resto é Impar se não é Par. 
                                                        //EX: 2/2 = 1, não tem (Par); 7/2 = 3,5, há resto (Impar);
            
            float número2 = float.Parse(Console.ReadLine());

            if(número2 % 2 == 0){
                Console.WriteLine ("Par"); //Diz se o numero é par;
            } else {
                Console.WriteLine ("Impar"); //Diz se o numero é par;
            }

            if(número1 > número2){ // Se o número que você deu (número1) é maior que o (número2);

                Console.WriteLine("Seu número é Par"); //Diz se o numero é par;
            } else {
                Console.WriteLine("Seu número é Impar"); //Diz se o numero é par;
            }

            if(número2 > número1){ // Se o número que você deu (número2) é maior que o (número1);
            
                Console.WriteLine($"O número {número2} é maior que o número {número1} ");
            } else if(número1 > número2) {
                Console.WriteLine($"O número {número1} é maior que o número {número2} ");
            }
            else{
                Console.WriteLine("Ambos são do mesmo valor.");
            }

        }
    }
}
