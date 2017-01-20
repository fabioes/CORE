using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroCaelum.Data.Repository.Interfaces
{
    interface ICursoRepository
    {
        IEnumerable<Curso> Listar();
        void Salvar(Curso curso);
        void Deletar(Curso curso);
    }
}
