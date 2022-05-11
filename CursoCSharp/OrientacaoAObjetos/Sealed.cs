using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    sealed class SemFilho  //classes seladas não permitem herança e nem sobreescrita de seus métodos!
    {
        public double ValorDaFortuna() 
        {
            return 1_407_033.63;
        }
    }

    //class SouFilho : SemFilho 
    //{
    
    //}
    class Sealed
    {
        public static void Executar() 
        {
            SemFilho p = new SemFilho();

            Console.WriteLine(p.ValorDaFortuna());
        }
    }
}
