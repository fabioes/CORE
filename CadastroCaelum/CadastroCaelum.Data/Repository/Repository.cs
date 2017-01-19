using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CadastroCaelum.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        protected DbSet<T> DbSet;

        public Repository(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public void Deletar(T entity)
        {
            using (Context)
            {
                Context.Remove(entity);
                Context.SaveChanges();
            }

        }
        public void Salvar(T entity)
        {
            using (Context)
            {
                if (Context.Entry(entity).State != EntityState.Modified)
                    Context.Set<T>().Add(entity);

                Context.SaveChanges();
            }

        }
        public IEnumerable<T> Listar()
        {
            return DbSet;
        }

    }
}
