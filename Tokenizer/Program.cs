using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de teste
            string entrada = "teste aa 'sdas'tokenizer= e ponto;{foda}&&m,&";
            //separadores
            string[] separadores = new string[] { "=", "{", "}", "(", ")", ";", ",", "." };
            //instancia o tokenizer
            Tokenizer obj = new Tokenizer();
            //tolkeniza
            obj.Tokenizar(entrada, separadores);
            //coloca tolkens numa lista e mostra o resultado
            string[] saida = obj.Tolkens();
            Console.WriteLine("quantidade de tolkens: "+saida.Length);
            Console.Write("tolkens: ");
            foreach (string s in saida)
            {
                Console.Write($"'{s}'");
            }
            Console.ReadKey();
        }
    }
}
