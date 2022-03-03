using System.Collections.Generic;

namespace Crud.interfaces
{
    public interface Irepositorio<T>
    {
        List <T> Lista();
        T retornaPorId( int Id);
        void Inserir(T entidade);
        void Excluir( int Id);
        void Atualizar( int Id, T entidade);
        int proximoId();
    
    }
}