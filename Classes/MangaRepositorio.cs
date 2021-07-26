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
            if(IdExists(id))
                listaMangas[id].Excluir();
            else
                Console.WriteLine(ItemNaoExiste);
        }

        public void AtualizarItem(int id, Manga item)
        {
            if(id >= ProxId())
                Console.WriteLine(ItemNaoExiste);    
            else
                listaMangas[id] = item;
        }

        public int ProxId()
        {
            return listaMangas.Count;
        }

        public bool IdExists(int id)
        {
            if(id >= ProxId() || !listaMangas[id].getAtivo())
                return false;
            return true;
        }
    }
}