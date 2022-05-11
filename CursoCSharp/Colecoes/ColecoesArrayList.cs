using System;
using System.Collections; // ArrayList esta apenas em collections não sendo permitido o uso de generics
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar() 
        {
            var arraylist = new ArrayList {
                "Palavra",
                3,
                true
            };
            
            arraylist.Add(3.14);

            foreach (var item in arraylist)
            {
                Console.WriteLine("{0} =>> {1}", item, item.GetType());
            }
        }
    }
}
