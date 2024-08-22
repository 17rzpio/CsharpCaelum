using System;
using System.IO;

namespace TesteCaelum
{
    class Program
    {
        static void Main(string[] args)
        {
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminhoArquivo = Path.Combine(pastaDocumentos, "text.txt");
            using (Stream entrada = File.Open(caminhoArquivo, FileMode.Open))
            using (TextReader leitor = new StreamReader(entrada))
            {
                string textoTotal = leitor.ReadToEnd();
                Console.WriteLine(textoTotal);

            }
        }
    }
}
//----------------------------------------------------------------------------------------------
//capítulo 22 exercício 6
//using System;
//using System.IO;

//namespace TesteCaelum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (Stream entrada = File.Open("text.txt", FileMode.Open))
//            using (TextReader leitor = new StreamReader(entrada))
//            {
//                string textoTotal = leitor.ReadToEnd();
//                Console.WriteLine(textoTotal); 

//            }
//        }
//    }
//}
//-------------------------------------------------------------------------------------------
//capitulo 22 exercício 5
//using System;
//using System.IO;

//namespace TesteCaelum
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Mensagem que vai para o terminal");
//            TextReader leitor = Console.In;
//            string linha = leitor.ReadLine();
//            while (linha != null)
//            {
//                linha = leitor.ReadLine();
//            }
//        }
//    }
//}
