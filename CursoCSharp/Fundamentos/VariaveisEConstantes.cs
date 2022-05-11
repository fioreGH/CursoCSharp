using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("A área é = "+ area);
        } 
    }
}
