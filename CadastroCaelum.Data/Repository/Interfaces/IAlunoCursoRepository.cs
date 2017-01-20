using System.Collections.Generic;


namespace CadastroCaelum.Data.Repository.Interfaces
{
    interface IAlunoCursoRepository
    {
        IEnumerable<AlunoCurso> Listar();
        void Salvar(AlunoCurso alunoCurso);
        void Deletar(AlunoCurso alunoCurso);
    }
}
