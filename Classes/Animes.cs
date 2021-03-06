using System;
using System.Collections.Generic;

namespace CadastroAniManga
{
    public class Animes : AnimeBaseClass
    {
        private string Titulo { get; set; }
        private List<Genero> Generos { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Studio { get; set; }
        private bool Ativo { get; set; }

        public Animes(int id, string titulo, List<Genero> generos, string descricao, int ano, string studio, bool ativo = true)
        {
            Id = id;
            Titulo = titulo;
            Generos = generos;
            Descricao = descricao;
            Ano = ano;
            Studio = studio;
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
                   "Studio: "   + Studio;
        }
    }
}