using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie meu atendimento com nota entre 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("ruim");
                    break;
                case 3:
                    Console.WriteLine("regular");
                    break;
                case 4:
                    Console.WriteLine("bom");
                    break;
                case 5:
                    Console.WriteLine("ótimo");
                    break;
                default:
                    Console.WriteLine("nota inválida");
                    break;
            }
            Console.WriteLine("fim");
        }
    }
}
