using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente 
    {
        public string Nome;
        public readonly DateTime Nascimento; // funciona como uma constante porém é declarada no contrutor em tempo de execução


        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() 
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }


    }
    class ReadOnly
    {
        public static void Executar() 
        {
            var novoCliente = new Cliente("Ana Maria", new DateTime(1987, 5, 23));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
