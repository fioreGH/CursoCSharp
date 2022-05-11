using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random randon = new Random();
            int numero = randon.Next(1, 51);

            Console.WriteLine("O numeros que queremos é {0}.", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero desejado? ", i);
                if (i == numero)
                {
                    Console.WriteLine("SIM!");
                    break;
                }
                else
                {
                    Console.WriteLine("NÃO!");
                }
            }
            Console.WriteLine("FIM!");
        }
    }
}
