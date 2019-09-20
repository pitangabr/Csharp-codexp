using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Efetuar o cadastro de usuário com os seguintes;
            //dadaos: Nome,Telefone e Email;

            Console.WriteLine("Execício de Arrays 2");

            string [] nomes = new string [3];
            string [] telefones = new string[3];
            string [] email = new string [3];

            int contador = 0;
            while(contador < 2){
                Console.WriteLine ("Digite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine ("Digite seu telefone");
                telefones [contador] = Console.ReadLine();

                Console.WriteLine ("Digite seu E-mail");
                email [contador] = Console.ReadLine();
                contador++;
            } // fim do While

            int contadorB = 0;
            while (contadorB <= 2){
                Console.WriteLine($"O cliente número {contadorB+1} - Nome: {nomes[contadorB]}, Tel: {telefones[contadorB]}, E-mail: {email[contadorB]}");
                contadorB++;
            }
        }
    }
}
