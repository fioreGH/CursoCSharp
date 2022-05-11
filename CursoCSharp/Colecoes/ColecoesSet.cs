using System;
using System.Collections.Generic;


namespace CursoCSharp.Colecoes
{

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Games of throne", 49.9);

            var carrinho = new HashSet<Produto>();  // ao contrario da lista, o set não é indexado e não aceita duplicação
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
            new Produto("Camisa", 29.9),
            new Produto("8ª temporada Games of thrones", 99.9),
            new Produto("Poster", 10),
            new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); // metodo usado para união de Hash

            Console.WriteLine(carrinho.Count);

            //carrinho.RemoveAt(3); //perde-se as funções indexadoras

            foreach (var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item)); //perde-se as funções indexadoras
                Console.WriteLine($"{item.Nome}, {item.Preco}");

            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);  // não é permitido duplicação
            Console.WriteLine(carrinho.Count);

        }
    }
}
