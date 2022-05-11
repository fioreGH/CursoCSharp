using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploDirectoryInfo
    {
        public static void Executar() 
        {
            var DirProjeto = @"~/OneDrive".ParseHome();

            var dirInfo = new DirectoryInfo(DirProjeto);

            Console.WriteLine("=======arquivos=======");
            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("===============diretorios=============");
            var pastas = dirInfo.GetDirectories();

            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);

        }
    }
}
