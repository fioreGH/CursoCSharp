using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar() 
        {
            string entrada; 

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo(a) {entrada}");

                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine().ToLower();

            } while (entrada == "s");
        }
    }
}
