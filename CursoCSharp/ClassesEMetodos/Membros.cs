using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() 
        {
            Pessoa cicrano = new Pessoa();
            cicrano.Nome = "Renato";
            cicrano.Idade = 21;

            Console.WriteLine($"{cicrano.Nome} tem {cicrano.Idade} anos.");

            cicrano.ApresentarNoConsole();

            var beltrano = new Pessoa();
            beltrano.Nome = "Beto";
            beltrano.Idade = 20;

            var apresentacaoBeltrano = beltrano.Apresentar();
            Console.WriteLine(apresentacaoBeltrano.Length);
            Console.WriteLine(apresentacaoBeltrano);
        }
    }
}
