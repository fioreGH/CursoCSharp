using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }

        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto
        {

            get => Preco - (desconto * Preco); // lambda

            //get 
            //{
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional()
        {

        }
        public CarroOpcional(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
        }

    }



    class Props
    {
        public static void Executar()
        {
            var opc1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(opc1.PrecoComDesconto);

            var opc2 = new CarroOpcional();
            opc2.Nome = "Direção Elétrica";
            opc2.Preco = 2349.9;

            Console.WriteLine(opc1.Nome);
            Console.WriteLine(opc1.Preco);

            Console.WriteLine(opc2.Nome);
            Console.WriteLine(opc2.Preco);
            Console.WriteLine(opc2.PrecoComDesconto);
        }
    }
}
