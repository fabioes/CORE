
using System.Collections.Generic;


namespace CadastroCaelum.Data.Repository.Interfaces
{
    interface IAlunoRepository
    {
        IEnumerable<Aluno> Listar();
        void Salvar(Aluno entity);
        void Deletar(Aluno entity);
    }
}
