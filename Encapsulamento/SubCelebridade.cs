using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //todos podem ver
        public string InfoPublica = "Tenho uns Instagra,!";

        // atributo protected (transmitido por herença)
        protected string CorDosOlhos = "verde";

        //mesmo projeto (assembly)
        internal ulong Celular = 5513987456321;

        //herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas Gírias";

        //mesma classe ou herança  no mesmo projeto (só finciona no c# > 7.2)
        private protected string SegredoDeFamilia = "Blá Blá";

        // private - atributo padrão (mesmo quando não colocamos nada...
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() 
        {
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(Celular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        
        }

    }
}
