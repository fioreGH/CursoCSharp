using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

    }
    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a) 
        {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0 ;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        }

    }

    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calcular = new CalculadoraComum();
            var resultado = calcular.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calcular.Subtrair(4, 5));
            Console.WriteLine(calcular.Multiplicar(4, 4));

            var calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            
            Console.WriteLine(resultado);
        }
    }
}
