using System;
using System.Collections.Generic;
using CadastroCaelum.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroCaelum.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {
        protected readonly DbContext Context;
        protected DbSet<Curso> DbSet;

        public CursoRepository(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<Curso>();
        }
        public void Deletar(Curso curso)
        {
            using (Context)
            {
                Context.Remove(curso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<Curso> Listar()
        {
            return DbSet;
        }

        public void Salvar(Curso curso)
        {
            using (Context)
            {
                if (Context.Entry(curso).State != EntityState.Modified)
                    Context.Set<Curso>().Add(curso);

                Context.SaveChanges();
            }
        }
    }
}
