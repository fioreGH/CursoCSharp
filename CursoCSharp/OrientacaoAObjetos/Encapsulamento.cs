using System;
using Encapsulamento;

namespace CursoCSharp.OrientacaoAObjetos
{
    public class FilhoNaoReconhecido : SubCelebridade 
    {
        public new void MeusAcessos() 
        {
            Console.WriteLine("Filho não Reconhecido....");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(Celular); //não acessa, pois não é membro do projeto
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia); //não acessa, pois é transmitido por herança apenas dentro do projeto
            //Console.WriteLine(UsaMuitoPhotoshop); //ningeum acessa, só a classe
        }
    }

    public class AmigoDistante 
    {
        public readonly SubCelebridade AmigoDisyante = new SubCelebridade();

        public void MeusAcessos() 
        {
            Console.WriteLine("Amigo Distante............");

            Console.WriteLine(AmigoDisyante.InfoPublica);
            //Console.WriteLine(AmigoDisyante.CorDosOlhos);
            //Console.WriteLine(AmigoDisyante.Celular);
            //Console.WriteLine(AmigoDisyante.JeitoDeFalar);
            //Console.WriteLine(AmigoDisyante.SegredoDeFamilia);
            //Console.WriteLine(AmigoDisyante.UsaMuitoPhotoshop);
        }
    }
    class Encapsulamento
    {
        public static void Executar() 
        {
            SubCelebridade sub = new SubCelebridade();
            
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoDistante().MeusAcessos();
        }
    }
}
