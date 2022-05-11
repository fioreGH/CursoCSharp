using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
    }
    class StructVsClasses
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // atribuição por valor a nova atribuição ao X ficará diferente na cópiaPonto1
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Cópia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // atribuição feita por referencia, ou seja, a nova atribuição afetara a copia, pois os 2 apontam para o mesmo lugar na memoria.
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Cópia Ponto 2 X:{0}", copiaPonto2.X);


        }
    }
}
