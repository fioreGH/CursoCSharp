using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        static public void Executar() 
        {
            var dateTime = new DateTime(year: 2022, month: 04, day: 01);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            //sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //com hora
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine("Hora: " + agora.Hour); //somente a hora
            Console.WriteLine("Data: " + agora.Minute);

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);

            //formatos com Tostring()

            Console.WriteLine(agora.ToString("dd"));
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("D"));
            Console.WriteLine(agora.ToString("g"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("dd-MM-yyyy HH:mm"));

        }
    }
}
