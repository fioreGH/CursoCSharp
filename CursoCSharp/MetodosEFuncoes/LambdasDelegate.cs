﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar() 
        {
            Operacao somar = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;

            Console.WriteLine(somar(3,3));
            Console.WriteLine(subtracao(5,2));
            Console.WriteLine(multiplicacao(12,8));

        }
    }
}
