using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)
        {
            numero = 0;  //valor precisa ser inicializado..... apenas pega o retorno da função por isso OUT
            numero = numero + 15;
        }

        public static void AlterarOut2(out int numero1, out int numero2) 
        {
            numero1 = 0;
            numero2 = 0;

            numero1 = numero1 + 20;
            numero2 = numero2 + 30;

        }
        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            AlterarOut(out int b); //declarar a variavel diretamente na chamada método
            Console.WriteLine(b);

            
            AlterarOut2(out int c, out int d); //declarar a variavel diretamente na chamada método (como se tivesse 2 retornos)
            Console.WriteLine($"{c}, {d}");
        }
    }
}
