using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto 
    {
        public string Nome;
        public double Preço;
        public static double Desconto = 0.1;

        public Produto(string nome, double preço, double desconto) 
        {
            Nome = nome;
            Preço = preço;
            Desconto = desconto;
        }

        public Produto() 
        {
            
        }

        public double CalcularDesconto() 
        {
            return (Preço - Preço * Desconto);
        }
    }
    class AtributosEstaticos
    {
        public static void Executar() 
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() { 
            Nome = "Borracha",
            Preço = 5.3,
            };

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.7; // atributo pertence a classe!

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
        }
    }
}
