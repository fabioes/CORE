using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaelum.Data.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Listar();
        void Salvar(T entity);
        void Deletar(T entity);
    }
}
