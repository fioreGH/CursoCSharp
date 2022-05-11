using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFuncaoAnonima
    {
        delegate string StringOperacao(string s);
        public static void Executar()
        {
            StringOperacao inverter = delegate (string s)
            {
                char[] chararray = s.ToCharArray();

                Array.Reverse(chararray);

                return new string(chararray);
            };

            Console.WriteLine(inverter("C# é um show!!!"));

        }

    }
}
