using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    
    class ParamentroPadrao
    {
        public static int Somar(int a = 1, int b = 1) // define o valor padrão, caso não enviei nada para a função será utilizado este valor
        {
            return a + b;
        }
        public static void Executar() 
        {
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(10,33));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar(b: 80)); //paramentro nomeado

        }
    }
}
