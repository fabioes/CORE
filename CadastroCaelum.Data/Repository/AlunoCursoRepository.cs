using System.Collections.Generic;
using CadastroCaelum.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroCaelum.Data.Repository
{
    public class AlunoCursoRepository : IAlunoCursoRepository
    {
        protected readonly DbContext Context;
        protected DbSet<AlunoCurso> DbSet;

        public AlunoCursoRepository(CaelumContext context)
        {
            Context = context;
            DbSet = context.Set<AlunoCurso>();
        }

        public void Deletar(AlunoCurso alunoCurso)
        {
            using (Context)
            {
                Context.Remove(alunoCurso);
                Context.SaveChanges();
            }
        }

        public IEnumerable<AlunoCurso> Listar()
        {
            return DbSet;
        }

        public void Salvar(AlunoCurso alunoCurso)
        {
            using (Context)
            {
                if (Context.Entry(alunoCurso).State != EntityState.Modified)
                    Context.Set<AlunoCurso>().Add(alunoCurso);

                Context.SaveChanges();
            }
        }
    }
}
