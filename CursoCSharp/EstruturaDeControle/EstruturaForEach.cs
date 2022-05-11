using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar() 
        {
            string palavra = "Olá!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }


            var alunos = new string[] { "ana", "paulo", "bia", "pedro" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
