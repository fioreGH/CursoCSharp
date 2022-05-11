using System;

namespace CursoCSharp.Fundamentos 
{
	class Interpolacao
    {
        public static void Executar()
        {
            String nome = "Notebook Gamer";
            String marca = "DELL";
            Double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");
        }
    }
}
