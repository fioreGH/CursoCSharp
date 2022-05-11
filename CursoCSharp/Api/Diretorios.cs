using System;
using System.IO;

namespace CursoCSharp.Api
{
    class Diretorios
    {
        public static void Executar() 
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var novoDirProjeto = @"~/OneDrive".ParseHome();

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=========== PASTAS ===============");
            var pastas = Directory.GetDirectories(novoDirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n =========== ARQUIVOS ===========");
            var arquivos = Directory.GetFiles(novoDirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n\n ============ RAIZ ============");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);

        }
    }
}
