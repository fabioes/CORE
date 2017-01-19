using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroCaelum.Data
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }
        public string NomeCurso { get; set; }
        public bool Completo { get; set; }
        public int PercentualCompleto { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
