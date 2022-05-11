using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() 
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;  // operador e
            Console.WriteLine("Comprou a TV de 50: {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;  // operador ou
            Console.WriteLine("Comprou sorvete: {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;     // ou exclusivo
            Console.WriteLine("Comprou a TV de 32: {0}", comprouTv32);

            Console.WriteLine("Mais saudável: {0}", !comprouSorvete);
        }
    }
}
