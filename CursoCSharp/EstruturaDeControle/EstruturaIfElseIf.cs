using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar() 
        {
            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Parabéns esta no quadro de honra!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Aluno em Recuperação");
            }
            else 
            {
                Console.WriteLine("Aluno Reprovado");
            }
        }
    }
}
