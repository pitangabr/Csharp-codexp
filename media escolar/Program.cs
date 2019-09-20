using System;

namespace media_escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de Média escolar");

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua primeira nota:");
            string valorDigitado = Console.ReadLine (); //recebe um texto
            float nota1 = float.Parse(valorDigitado); // converte o texte em número(float)

            Console.WriteLine("Digite su segunda nota:");
            float nota2 = float.Parse (Console.ReadLine()); // recebe o valor digitado e converte em número

            //Processamento

            float media = (nota1+nota2)/2;
            string resultado; // String sem valor

            if(media >=7){ // como se fosse um sim
                resultado = "Aprovado"; // Atributo valor
            }else{ // como se fosse um não
                resultado = "Reprovado";
            }

            Console.WriteLine ($"O(A) aluno {nome} com a média {media} está {resultado}");
        }
    }
}
