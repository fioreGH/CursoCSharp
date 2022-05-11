using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue  // first in first out
    {
        public static void Executar() 
        {
            var fila = new Queue<string>();

            fila.Enqueue("fulano");  //adiciona itens na fila
            fila.Enqueue("Beltrano");
            fila.Enqueue("Cicrano");

            Console.WriteLine(fila.Peek());

            Console.WriteLine(fila.Count);

            fila.Dequeue(); // remove itens da fila 

            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();   //fila GENERICA qualquer tipo faz parte do colection apenas....
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));

        } 
    }
}
