using System;
using System.Collections.Generic;
using CadastroAniManga.Interfaces;

namespace CadastroAniManga
{
    public class AnimeRepositorio : IRepositorio<Animes>
    {
        private List<Animes> listaAnimes = new List<Animes>();
        private const string ItemNaoExiste = "Erro: Item não pertence a lista";

        public  List<Animes> Lista()
        {
            return listaAnimes;
        }

        public Animes BuscaPorId(int id)
        {
            return listaAnimes[id];
        }

        public void InsereItem(Animes item)
        {
            listaAnimes.Add(item);
        }

        public void RemoveItem(int id)
        {
            if(IdExists(id))
                listaAnimes[id].Excluir();
            else
                Console.WriteLine(ItemNaoExiste);
        }

        public void AtualizarItem(int id, Animes item)
        {
            if(id >= ProxId())
                Console.WriteLine(ItemNaoExiste);    
            else
                listaAnimes[id] = item;
        }

        public int ProxId()
        {
            return listaAnimes.Count;
        }

        private bool IdExists(int id)
        {
            if(id >= ProxId() || !listaAnimes[id].getAtivo())
                return false;
            return true;
        }
    }
}