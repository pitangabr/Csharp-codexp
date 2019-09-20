using System;

namespace Idades_e_Categorias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Idades e Categorias");
            
            Console.WriteLine ("Digite sua idade:");
            int idade = int.Parse (Console.ReadLine());

            if(idade <= 7){
                Console.WriteLine ("Sua idade se encaixa na Categoria Infantil A");
            }else if(idade <= 10) {
                Console.WriteLine ("Sua idade se encaixa na Categoria Infantil B");
            } else if(idade <= 13){
                Console.WriteLine ("Sua idade se encaixa na Categoria Juvenil A");
            } else if(idade <= 17){
                Console.WriteLine ("Sua idade se encaixa na Categoria Juvenil B");
            } else {
                Console.WriteLine ("Sua idade se encaixa na Categoria Adulto");
            }
        }
    }
}
