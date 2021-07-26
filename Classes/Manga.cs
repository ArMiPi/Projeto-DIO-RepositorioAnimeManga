using System;
using System.Collections.Generic;

namespace CadastroAniManga
{
    public class Manga : MangaBaseClass
    {
        private string Titulo { get; set; }
        private List<Genero> Generos { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Autor { get; set; }
        private bool Ativo { get; set; }

        public Manga(int id, string titulo, List<Genero> generos, string descricao, int ano, string autor, bool ativo = true)
        {
            Id = id;
            Titulo = titulo;
            Generos = generos;
            Descricao = descricao;
            Ano = ano;
            Autor = autor;
            Ativo = ativo;
        }

        public string getTitulo()
        {
            return Titulo;
        }

        public int getId()
        {
            return Id;
        }

        public bool getAtivo()
        {
            return Ativo;
        }

        public void Excluir()
        {
            Ativo = false;
        }

        public override string ToString()
        {
            return "ID: "       + Id                            + Environment.NewLine +
                   "Título: "   + Titulo                        + Environment.NewLine +
                   "Ano: "      + Ano                           + Environment.NewLine +
                   "Gêneros: "  + string.Join(", ", Generos)    + Environment.NewLine +
                   "Autor: "    + Autor;
        }
    }
}