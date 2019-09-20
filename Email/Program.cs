using System;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de E-mail");
            string Email;

            do
            {
              Console.WriteLine("Digite seu E-mail");
              Email = Console.ReadLine();
            } while ((! Email.Contains("@")) || (!Email.Contains(".")));

            string senha;
            do{
                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();
            }while (senha.Length <= 6);

        }
    }
}