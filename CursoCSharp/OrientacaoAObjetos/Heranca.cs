using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos
{
    public class Carro 
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velociadeMaxima)
        {
            VelocidadeMaxima = velociadeMaxima;
        }

        protected int AlterarVelocidade(int delta) 
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else 
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()  // para poder sobreescrever o metodo tem que usar o virtual....
        {
            return AlterarVelocidade(5);
        }

        public int Frear() 
        {
            return AlterarVelocidade(-5);
        }

        
    }

    public class Uno : Carro
    {
        public Uno() : base(200) // construtor da classe pai
        {
        }
    }

    public class Ferrari : Carro 
    {
        public Ferrari() : base(350) 
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        //ocultar o método da classe PAI

        public new int Frear() 
        {
            return AlterarVelocidade(-15);
        }


    }

    class Heranca
    {
        public static void Executar() 
        {
            Console.WriteLine("Carro Uno....");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar()); 
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Carro Ferrari....");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo generico Carro...."); 
            Carro carro3 = new Ferrari();  // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo generico Carro....");
            carro3 = new Uno();// Polimorfismo mesma variavel assundo multiplas formas
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
