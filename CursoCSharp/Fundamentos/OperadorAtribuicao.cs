using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorAtribuicao
    {
        public static void Executar() 
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine("O resultado é: "+ num1);

            int a = 1;
            int b = a;

            a++;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joão";

            dynamic d = c;
            d.nome = "maria";

            Console.WriteLine(c.nome);




        }
    }
}
