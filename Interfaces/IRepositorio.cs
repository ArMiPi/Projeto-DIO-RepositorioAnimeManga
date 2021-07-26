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
                - bool
            Descrição:
                - Retorna true caso o id represente um item presente na lista
                - Retorna false caso o id represente um item exluído ou que não pertence à lista
        */
        bool IdExists(int id);
    }
}