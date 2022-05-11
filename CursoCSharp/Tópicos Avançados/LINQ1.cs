using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Tópicos_Avançados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

    }
    class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno(){Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno(){Nome = "Andre", Idade = 21, Nota = 4.3},
                new Aluno(){Nome = "Ana", Idade = 25, Nota = 9.5},
                new Aluno(){Nome = "Jorge", Idade = 20, Nota = 8.5},
                new Aluno(){Nome = "Ana", Idade = 21, Nota = 7.7},
                new Aluno(){Nome = "Julia", Idade = 22, Nota = 7.5},
                new Aluno(){Nome = "Marcio", Idade = 18, Nota = 6.8}

            };

            Console.WriteLine("=========== Lista Aprovados ===========");
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => a.Nome); // 1 unica linha faço uma nova lista e ainda monto um critério + fácil que o uso do for

            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("=========== lista de chamada ===========");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);

            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("=========== lista de chamada (aprovados) organizados por idade ==========="); //muito parecido com SQL
            var alunosAprovados = from aluno in alunos where aluno.Nota >= 7 orderby aluno.Idade select aluno.Nome;

            foreach (var aprovado in alunosAprovados)
            {
                Console.WriteLine(aprovado);
            }
        }
    }
}
