using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar() 
        {
            DesafioAtributo desafioAtributo = new DesafioAtributo();
            desafioAtributo.a = 20;
            Console.WriteLine($"Valor de A é: {desafioAtributo.a}");
        }
    }
}
