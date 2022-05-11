using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Raphael";

            Console.WriteLine(nome);

            var idade = 0; // variaveis de inferencia precisam ser iniciadas para que o compilar identifique seu tipo
            idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 8;
            Console.WriteLine(a+b );
        }
    }
}
