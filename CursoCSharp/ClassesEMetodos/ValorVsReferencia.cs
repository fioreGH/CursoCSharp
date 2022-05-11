using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente 
    {
        public string Nome;  //passa por referencia
        public int Idade;
    }

    //public struct Dependente
    //{
    //    public string Nome;  //passa por valor
    //    public int Idade;
    //}
    class ValorVsReferencia
    {
        public static void Executar() 
        {
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"{numero}, {copiaNumero}");

            numero++;

            Console.WriteLine($"{numero}, {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDependente = dep;

            Console.WriteLine($"{dep.Nome}, {copiaDependente.Nome}");
            Console.WriteLine($"{dep.Idade}, {copiaDependente.Idade}");

            copiaDependente.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome}, {copiaDependente.Nome}");
            Console.WriteLine($"{dep.Idade}, {copiaDependente.Idade}");

        }
    }
}
