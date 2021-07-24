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
                - Caso exista um item com mesmo id, será apresentada uma mensagem de erro
                  e o item não será inserido
        */
        void InsereItem(T item);

        /*
            Entrada:
                - int id: Número identificador do item
            Descrição:
                - Remove um item com base em seu id. 
                - Se o item não existir/estiver desativado, será apenas apresentada uma mensagem indicando
                  que o item não está presente na lista
        */
        void RemoveItem(int id);

        /*
            Entradas:
                - int id: Número identificador do item
                - T item: Item atualizado
            Descrição:
                - Substitui o item que possuir o id passado pelo novo item
                - Caso não exista um item com o id especificado, é apresentada uma mensagem indicando
                  que o item não está presente na lista
        */
        void AtualizarItem(int id, T item);

        /*
            Saída:
                - int: Próximo identificador disponível
            Descrição:
                - Retorna um inteiro que representa o próximo identificador disponível
        */
        int ProxId();
    }
}