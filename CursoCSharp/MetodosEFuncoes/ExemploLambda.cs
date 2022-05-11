using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>       //lambda é uma função anonima e é essa função é armazenada em uma variável
            {
                Console.WriteLine("Lambda com C#!");

            };

            algoNoConsole();

            Func<int> jogarDados = () =>             //Func com apenas 1 indicação de tipo ....é o seu retorno
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDados());

            Func<int, string> conversorHex = numero => numero.ToString("X");  //Func com 2 ou mais tipo.... todos são paramentros e o ultimo é o seu retorno

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
