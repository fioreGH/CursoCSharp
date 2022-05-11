using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica 
    {   
        //método de classe ou método estático
        public static int Somar(int a, int b) 
        {
            return a + b;
        }

        //método de instância
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar() 
        {
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine("O resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica(); //precisa ser instânciado
            Console.WriteLine(calc.Multiplicar(2,2));
        }
    }
}
