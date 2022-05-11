using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo // não tem uma relação de herança mais esta dentro do mesmo projeto
    {
        public readonly SubCelebridade amigo = new SubCelebridade();  //acessar por composição.... tem que ter uma instancia da classe!!!

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo proximo........");

            Console.WriteLine(amigo.InfoPublica); //acessa por ser publico
            //Console.WriteLine(amigo.CorDosOlhos); // não acessa por ser protected (transmitido apenas por heranç)
            Console.WriteLine(amigo.Celular); //acessa pois é interno (dentro do projeto)
            Console.WriteLine(amigo.JeitoDeFalar); //acessa pois pode ser transmitido por herança ou interno! mesmo projeto
            //Console.WriteLine(amigo.SegredoDeFamilia); // não acessa pois só é transmitido por herença
            // Console.WriteLine(amigo.UsaMuitoPhotoshop); // não acesso, pois, é privado e apenas a classe acessa 

        }
    }
}
