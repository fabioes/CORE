using System;
using System.ComponentModel.DataAnnotations;


namespace CadastroCaelum.Data
{
    public class AlunoCurso
    {
        [Key]
        public int Id { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public bool Completo { get; set; }
        public int PercentualCompleto { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
