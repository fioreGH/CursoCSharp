using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);

        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double q, double r)
        {
            return q + r;
        }

        static void MeuImprimirSoma(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static public void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.8));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(3.5, 7);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2,3));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(4.3, 7.3);

        }
    }
}
