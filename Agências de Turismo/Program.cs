﻿using System;

namespace Agencias_de_Turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agência de Turismo");

            string [] nome = new string [2];
            string [] origem = new string [2];
            string [] destino = new string [2];
            DateTime [] data = new DateTime [2]; // DateTime Representa um momento no tempo, geralmente expresso como uma data e hora do dia.

            int opcao = 0; int contador = 0;
                            

            do{
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar Passagem");
                Console.WriteLine("2 - Listar Passagens");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao){
                    case 1: 
                    Console.WriteLine("Vamos Cadastrar Agora");
                    string resposta;

                    do{
                        if(contador < 2){
                        Console.WriteLine("O nome do Passageiro");
                        nome [contador] = (Console.ReadLine ());

                        Console.WriteLine("Digite a Origem");
                        origem [contador] = (Console.ReadLine());

                        Console.WriteLine("Digite o Destino");
                        destino [contador] = (Console.ReadLine());

                        Console.WriteLine("Digite a Data do Vôo");
                        data [contador] = DateTime.Parse (Console.ReadLine());

                        Console.WriteLine("Você deseja cadastrar mais um? S/N"); // escreve o que vai aparecer
                        resposta = Console.ReadLine (); // leitura do que vc escreveu
                        contador++;
                        } else{
                            Console.WriteLine("Você deseja cadastrar mais um? S/N");
                            break;
                        }
                    } while(resposta == "S");

                    break;
                    case 2:
                    Console.WriteLine("Listando as Passagens");
                        int contadorB = 0;
                        while(contadorB < 2)
                        {
                            Console.WriteLine($"Passageiro nome: {nome[contadorB]}, origem: {origem[contadorB]}, destino: {destino[contadorB]}, data: {data[contadorB]}");
                            contadorB++;
                        }
                    break;
                    case 0:
                    Console.WriteLine("Obrigado por usar nosso sistema");
                    break;
                } // fim switch

            } while(opcao != 0);

            // Console.WriteLine("Obrigado por usar nosso sistema"); 
        }
    }
}
