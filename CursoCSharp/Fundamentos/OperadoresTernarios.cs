using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar() 
        {
            var nota = 7.0;
            bool bomComportamento = false;
            var resultado = nota >= 7 && bomComportamento ? "aprovado" : "reprovado";
            Console.WriteLine("O resultado é : "+ resultado);

        }
    }
}
