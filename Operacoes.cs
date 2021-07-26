using System;
using System.Collections.Generic;

namespace CadastroAniManga
{
    public static class Operacoes
    {
        const string NoAnimeIdError = "Nenhum anime com este id encontrado";
        const string NoMangaIdError = "Nenhum manga com este id encontrado";
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
            Console.WriteLine("C - Limpar a tela");
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
                    AddManga();
                    break;
                case "3":
                    RmvAnime();
                    break;
                case "4":
                    RmvManga();
                    break;
                case "5":
                    AllAnimes();
                    break;
                case "6":
                    AllMangas();
                    break;
                case "7":
                    AnimeInfo();
                    break;
                case "8":
                    MangaInfo();
                    break;
                case "9":
                    //AtualizarAnime();
                    break;
                case "10":
                    //AtualizarManga();
                    break;
                case "C":
                    Console.Clear();
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

        public static void AddManga()
        {
            Console.WriteLine("----- INSERIR MANGA -----");
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
            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            Manga manga = new Manga(id: manrep.ProxId(), 
                                      titulo: titulo, 
                                      generos: generos, 
                                      descricao: descricao, 
                                      ano: ano, 
                                      autor: autor);

            manrep.InsereItem(manga);
            Console.WriteLine();
            Console.WriteLine("Manga adicionado");
        }

        public static void RmvAnime()
        {
            Console.WriteLine("----- REMOVER ANIME -----");
            Console.WriteLine();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if(anirep.IdExists(id))
            {
                anirep.RemoveItem(id);
                Console.WriteLine("Anime excluido");
            }
            else
                Console.WriteLine(NoAnimeIdError);
        }

        public static void RmvManga()
        {
            Console.WriteLine("----- REMOVER MANGA -----");
            Console.WriteLine();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if(manrep.IdExists(id))
            {
                manrep.RemoveItem(id);
                Console.WriteLine("Manga excluido");
            }
            else
                Console.WriteLine(NoMangaIdError);
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

        public static void AllMangas()
        {
            Console.WriteLine("----- ALL MANGAS -----");
            foreach(Manga m in manrep.Lista())
            {
                Console.Write($"#{m.Id} - {m.getTitulo()} ");
                if(!m.getAtivo())
                    Console.Write("**EXCLUÍDO**");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void AnimeInfo()
        {
            Console.WriteLine("----- ANIME INFO -----");
            Console.WriteLine();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(id < anirep.ProxId())
            {
                if(!anirep.BuscaPorId(id).getAtivo())
                    Console.WriteLine("** EXCLUÍDO **");
                Console.Write(anirep.BuscaPorId(id).ToString());
            }
            else
                Console.Write(NoAnimeIdError);

            Console.WriteLine();
        }

        public static void MangaInfo()
        {
            Console.WriteLine("----- MANGA INFO -----");
            Console.WriteLine();
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(id < manrep.ProxId())
            {
                if(!manrep.BuscaPorId(id).getAtivo())
                    Console.WriteLine("** EXCLUÍDO **");
                Console.Write(manrep.BuscaPorId(id).ToString());
            }
            else
                Console.Write(NoMangaIdError);

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