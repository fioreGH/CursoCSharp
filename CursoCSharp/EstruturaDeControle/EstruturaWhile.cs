using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar() 
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 31);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira seu Palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor.... tente novamente");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
                else 
                {
                    Console.WriteLine("Maior.... tente novamente");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }

        }
    }
}
