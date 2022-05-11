using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar() 
        {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;

            var totalComDesconto = total - (total * desconto);

            Console.WriteLine($"O valor é: {preco} o valor do imposto é {imposto} o valor final com desconto é: {totalComDesconto}" );

            //IMC

            double peso = 95;
            double altura = 1.85;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("O indice de IMC é {0}", imc);

            // PAR OU IMPAR

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar % 2);





        }
    }
}
