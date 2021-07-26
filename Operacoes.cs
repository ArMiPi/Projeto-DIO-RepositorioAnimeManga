using System;
using System.Collections.Generic;

namespace CadastroAniManga
{
    public static class Operacoes
    {
        static AnimeRepositorio anirep = new AnimeRepositorio();
        static MangaRepositorio manrep = new MangaRepositorio();
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar um Anime");
            Console.WriteLine("2 - Adicionar um Manga");
            Console.WriteLine("3 - Remover um Anime");
            Console.WriteLine("4 - Remover um Manga");
            Console.WriteLine("5 - Listar todos os Animes");
            Console.WriteLine("6 - Listar todos os Mangas");
            Console.WriteLine("7 - Exibir detalhes de um Anime");
            Console.WriteLine("8 - Exibir detalhes de um Manga");
            Console.WriteLine("9 - Atualizar um Anime");
            Console.WriteLine("10 - Atualizar um Manga");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
        }

        public static void Opcao(string opt)
        {
            switch(opt)
            {
                case "1":
                    AddAnime();
                    break;
                case "2":
                    //AddManga();
                    break;
                case "3":
                    //RmvAnime();
                    break;
                case "4":
                    //RmvManga();
                    break;
                case "5":
                    AllAnimes();
                    break;
                case "6":
                    //AllMangas();
                    break;
                case "7":
                    //AnimeInfo();
                    break;
                case "8":
                    //MangaInfo();
                    break;
                case "9":
                    //AtualizaAnime();
                    break;
                case "10":
                    //AtualizaManga();
                    break;
                case "X":
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }

        public static void AddAnime()
        {
            Console.WriteLine("----- INSERIR ANIME -----");
            Console.WriteLine();
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            ListarGeneros();
            Console.WriteLine("Adicionar gêneros (-1 para sair)");
            List<Genero> generos = new List<Genero>();
            for(int g = int.Parse(Console.ReadLine()); g != -1; g = int.Parse(Console.ReadLine()))
                generos.Add((Genero)g);
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Studio: ");
            string studio = Console.ReadLine();

            Animes anime = new Animes(id: anirep.ProxId(), 
                                      titulo: titulo, 
                                      generos: generos, 
                                      descricao: descricao, 
                                      ano: ano, 
                                      studio: studio);

            anirep.InsereItem(anime);
            Console.WriteLine();
            Console.WriteLine("Anime adicionado");
        }

        public static void AllAnimes()
        {
            Console.WriteLine("----- ALL ANIMES -----");
            foreach(Animes a in anirep.Lista())
            {
                Console.Write($"#{a.Id} - {a.getTitulo()} ");
                if(!a.getAtivo())
                    Console.Write("**EXCLUÍDO**");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void ListarGeneros()
        {
            Console.WriteLine("Gêneros:");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.Write(i + " - " + Enum.GetName(typeof(Genero), i) + "\t\t");
                if(i % 4 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}