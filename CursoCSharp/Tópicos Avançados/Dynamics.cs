using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Tópicos_Avançados
{
    class Dynamics
    {
        public static void Executar() 
        {
            dynamic meuObjeto = "teste";

            meuObjeto = 3;

            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Cleber Santana";
            aluno.nota = 8.5;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}
