using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    public abstract class Celular   //você só pode instanciar classes concretas!!!!! 
    {
        public abstract string Assistente();

        public string Tocar() 
        {
            return "Trim, Trim, Trim....";
        }
    }

    public class Samsung : Celular 
    {
        public override string Assistente() //é necessário implementar o método abstrato herdado
        {
            return "Olá meu nome é Bixby!";
        }
    }

    public class Iphone : Celular 
    {
        public override string Assistente() //é necessário implementar o método abstrato herdado
        {
            return "Olá meu nome é Siri!";
        }
    }
    class Abstract
    {
        public static void Executar() 
        {
            var celulares = new List<Celular>()
            {
                new Samsung(),
                new Iphone()
            };

            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        } 
    }
}
