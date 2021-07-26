using System;
using System.Collections.Generic;
using CadastroAniManga.Interfaces;

namespace CadastroAniManga
{
    public class MangaRepositorio : IRepositorio<Manga>
    {
        private List<Manga> listaMangas = new List<Manga>();
        private const string ItemNaoExiste = "Erro: Item não pertence a lista";

        public  List<Manga> Lista()
        {
            return listaMangas;
        }

        public Manga BuscaPorId(int id)
        {
            return listaMangas[id];
        }

        public void InsereItem(Manga item)
        {
            listaMangas.Add(item);
        }

        public void RemoveItem(int id)
        {
            listaMangas[id].Excluir();
        }

        public void AtualizarItem(int id, Manga item)
        {
            listaMangas[id] = item;
        }

        public int ProxId()
        {
            return listaMangas.Count;
        }

        public int VerificaId(int id)
        {
            if(id >= ProxId())
                return -1;
            else if(listaMangas[id].getAtivo())
                return 0;
            else
                return 1;
        }
    }
}