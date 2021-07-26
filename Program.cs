using System;

namespace CadastroAniManga
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt = "0";

            while(!opt.Equals("X"))
            {
                Operacoes.Menu();
                opt = Console.ReadLine().ToUpper();
                Console.WriteLine();
                Operacoes.Opcao(opt);
            }
        }
    }
}
