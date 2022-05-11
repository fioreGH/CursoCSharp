using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() 
        {
            int inteiro = 10;
            double quebrado = inteiro;    // conversão implicita
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota; //casting
            Console.WriteLine("Nota trunca é {0}", notaTruncada);  // conversão explicita

            Console.WriteLine("Digite a sua idade: ");
            String idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine($"idade inserida {idadeInt}");

            int idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("A idade digitada foi {0}",idadeInteiro);

            //converter string de forma mais segura
            
            //1ª forma
            Console.WriteLine("Digite um número: ");
            String palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado 1 é {numero}");

            //2º Forma
            Console.WriteLine("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado 2 é {numero2}");

        }
    }
}
