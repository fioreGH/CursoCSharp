using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Tópicos_Avançados
{
    class LINQ2
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

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"Nome: {pedro.Nome} - Nota: {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); //para evitar dar o erro retorna o valor default de um objeto (null)
            if (fulano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var primeiroAlunoEncontrado = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Nome: {primeiroAlunoEncontrado.Nome} - Nota: {primeiroAlunoEncontrado.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));  //para evitar dar o erro retorna o valor default de um objeto (null)
            if (sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ultimoAlunoEncontrado = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Nome: {ultimoAlunoEncontrado.Nome} - Nota: {ultimoAlunoEncontrado.Nota}");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine($"Somatório turam: {somatorioNotas}");

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine($"Media turma: {mediaNotas}");


        }
    }
}
