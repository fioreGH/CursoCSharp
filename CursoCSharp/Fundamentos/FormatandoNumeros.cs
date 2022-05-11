using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() 
        {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##")); //pode ser o F2

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); //completa com casas a esquerda até ficar com o numero de dígitos
        }
    }
}
