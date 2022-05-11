using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() 
        {
            Console.WriteLine("Qual seu nome?");
            String nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário?");
            double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e ganha R$ {salario} ");
        }
    }
}
