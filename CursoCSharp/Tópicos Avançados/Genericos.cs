using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Tópicos_Avançados
{
    public class Caixa<T>
    {
        T valorProvado;

        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }
    }
    class Genericos
    {
        public static void Executar()
        {

        }
    }
}
