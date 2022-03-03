using System;
using System.Collections.Generic;
using Crud.interfaces;

namespace Crud
{
    public class CrudRepositorio : Irepositorio<Clientes>
    {
        public void Atualizar(int Id, Clientes objeto)
        {
            listaCliente [Id] = objeto;
        }

        public void Excluir(int Id)
        {
            listaCliente[Id] Excluir();
        }

        public void Inserir(Clientes entidade)
        {
            throw new NotImplementedException();
        }

        public List<Clientes> Lista()
        {
            throw new NotImplementedException();
        }

        public int proximoId()
        {
            throw new NotImplementedException();
        }

        public Clientes retornaPorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
