using CadastroCaelum.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CadastroCaelum.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        protected readonly DbContext Context;
        protected DbSet<Aluno> DbSet;

        public AlunoRepository(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<Aluno>();
        }

        public void Deletar(Aluno aluno)
        {
            using (Context)
            {
                Context.Remove(aluno);
                Context.SaveChanges();
            }

        }
        public void Salvar(Aluno aluno)
        {
            using (Context)
            {
                if (Context.Entry(aluno).State != EntityState.Modified)
                    Context.Set<Aluno>().Add(aluno);

                Context.SaveChanges();
            }

        }
        public IEnumerable<Aluno> Listar()
        {
            return DbSet;
        }

    }
}
