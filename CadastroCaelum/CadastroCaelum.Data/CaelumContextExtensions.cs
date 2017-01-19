using System.Collections.Generic;

namespace CadastroCaelum.Data
{
    public static class CaelumContextExtensions
    {
        public static void EnsureSeedData(this CaelumContext context)
        {
            context.Curso.AddRange(
              new Curso { NomeCurso = "ASP.NET Core" },
              new Curso { NomeCurso = "Android 1" }
              );
            context.SaveChanges();
            context.Aluno.AddRange(
                new Aluno { NomeAluno = "Fulano", Cpf = "123.456.789-10" },
                new Aluno { NomeAluno = "Ciclano", Cpf = "123.456.789-10" }
                );
            context.SaveChanges();
        }
    }
}
