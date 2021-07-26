using System.Collections.Generic;

namespace CadastroAniManga.Interfaces
{
    public interface IRepositorio<T>
    {
        /*
            Saída:
                - List<T>: Lista vazia
            Descrição:
                - Instancia uma lista
        */
        List<T> Lista();

        /*
            Entrada:
                - int id: Número identificador do item
            Saída:
                - T: Item com identificador id
            Descrição:
                - Retorna o item que possuir como número identificador o id passado
        */
        T BuscaPorId(int id);

        /*
            Entrada:
                - T item: Item a ser inserido na lista
            Descrição:
                - Insere um item na lista. 
        */
        void InsereItem(T item);

        /*
            Entrada:
                - int id: Número identificador do item
            Descrição:
                - Remove um item com base em seu id. 
        */
        void RemoveItem(int id);

        /*
            Entradas:
                - int id: Número identificador do item
                - T item: Item atualizado
            Descrição:
                - Substitui o item que possuir o id passado pelo novo item
        */
        void AtualizarItem(int id, T item);

        /*
            Saída:
                - int: Próximo identificador disponível
            Descrição:
                - Retorna um inteiro que representa o próximo identificador disponível
        */
        int ProxId();

        /*
            Entrada:
                - int id: Número identificador do item
            Saída:
                - int : [-1, 0, 1]
            Descrição:
                - Retorna -1 caso o item não pertença à lista
                - Retorna 0 caso o item pertença à lista
                - Retorna -1 caso o item tenha sido excluído
        */
        int VerificaId(int id);
    }
}