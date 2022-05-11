using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Tópicos_Avançados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;

            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine("O valor de num1: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variável não possui um valor!");
            }

            int valor = num1 ?? 1000; //possibilidade de usar um valor padrão caso seja nulo

            Console.WriteLine(valor);

            bool? boleano = null;

            bool resultado = boleano.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value;
                int y = num2.Value;

                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
