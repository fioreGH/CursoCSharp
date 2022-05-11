using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar() 
        {
            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);

            for (int i = 1; i <= tamanhoDaTurma; i++)
            {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                Double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;

            Console.WriteLine($"Média da turma: {media}");
        }
    }
}
