﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto 
    {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada : Ponto 
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y) 
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) 
        {
            X += delta;
            Y += delta;
        }

    }
    class ExemploStruct
    {
        public static void Executar() 
        {
            Coordenada cordenadaInicial;
            cordenadaInicial.X = 2;
            cordenadaInicial.Y = 2;

            Console.WriteLine("Coordena Inicial");
            Console.WriteLine("X = {0}", cordenadaInicial.X);
            Console.WriteLine("Y = {0}", cordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
