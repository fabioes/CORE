
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroCaelum.Data
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }       
        public List<Curso> Curso { get; set; }
    }
}
